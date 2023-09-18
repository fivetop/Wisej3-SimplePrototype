using DataClass;
using simplepa2.UI.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Views
{
    public partial class View_BBSAnchor : Wisej.Web.UserControl
    {
		private Comp_BBSAchchorBSStatus comp_BBSAnchorBSStatus;
		private Comp_BBSAnchorPlayer comp_BBSAnchorPlayer;
		private Comp_BBSAnchorPresetQuick comp_BBSAnchorPresetQuick;
		private Comp_BBSAnchorZone comp_BBSAnchorZone;

		private int MUSIC_FIRST_FILE = 0;

		List<AssetsRow> SelAsset { get; set; } = new List<AssetsRow>();
		List<MusicsRow> SelMusic { get; set; } = new List<MusicsRow>();
		int bSTreeid { get; set; } = 0;


		// private Comp_BB


		public string strEMNAME;
		public int intBBSchno;

		public View_BBSAnchor()
		{
			InitializeComponent();
		}

		private void View_BBSAnchor_Load(object sender, EventArgs e)
		{
			reDraw();

		}

		internal void reDraw()
		{
			setupUIComponent();

		}

		public void setupUIComponent()
		{
			comp_BBSAnchorBSStatus = new Comp_BBSAchchorBSStatus();
			comp_BBSAnchorPlayer = new Comp_BBSAnchorPlayer();
            comp_BBSAnchorPlayer.PlayerStarter += Comp_BBSAnchorPlayer_PlayerStarter;
            comp_BBSAnchorPlayer.PlayerStop += Comp_BBSAnchorPlayer_PlayerStop;
            comp_BBSAnchorPlayer.Dock = DockStyle.Fill;
            comp_BBSAnchorPresetQuick = new Comp_BBSAnchorPresetQuick();
			comp_BBSAnchorZone = new Comp_BBSAnchorZone();

			this.pn_BBSMonitor.Controls.Add(comp_BBSAnchorBSStatus);
			this.pn_playerList.Controls.Add(comp_BBSAnchorPlayer);
			this.splitContainer2.Panel1.Controls.Add(comp_BBSAnchorPresetQuick);
			this.splitContainer2.Panel2.Controls.Add(comp_BBSAnchorZone);
		}

        private void Comp_BBSAnchorPlayer_PlayerStop(object sender, Comp_BBSAnchorPlayer.CompBBSAnchorPlayerStopEventArgs e)
        {
			this.comp_BBSAnchorPlayer.audioPlayerStop();
			// 프로그램 음원 종료 처리  및 뒷정리

			// 플레이어 초기화 (재검토 같은 곡 초기화 안됨) 
			this.comp_BBSAnchorPlayer.setupFirstFileForPlay(MUSIC_FIRST_FILE);

			// 방송 상태 변경
			this.comp_BBSAnchorBSStatus.setb_bsOutput(false);

			// 오차장님 코드
			방송중지로직();
			bSTreeid = 0;
		}

        private void Comp_BBSAnchorPlayer_PlayerStarter(object sender, Comp_BBSAnchorPlayer.CompBBSAnchorPlayerPlayEventArgs e)
        {			

			// 00. 음원 리스트 셋업
			SelMusic = e.SelMusic;

			// 01 방송 지역 리스트를 불러오기
			SelAsset = this.comp_BBSAnchorZone.getSelectedAssetList();
			
			// 02. 오차장님 서버 : Validation
			if (SelAsset.Count() < 1 || SelMusic.Count() < 1)
			{
				AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Error, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Hand, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Question, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Stop, true, ContentAlignment.MiddleCenter);
				//AlertBox.Show("지역과 음원을 선택하여 주세요.", MessageBoxIcon.Warning, true, ContentAlignment.MiddleCenter);

				this.comp_BBSAnchorPlayer.audioPlayerStop();
				return;
			}

			// 03. EMSERVER GET STATE
			int ret = gweb.dBSqlite.EMServerGetState(SelAsset[0]);

			if (ret == 0)
			{
				AlertBox.Show("해당 지역 서버를 확인 바랍니다.", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
				this.comp_BBSAnchorPlayer.audioPlayerStop();
				return;
			}

			// 선택한 지역에 방송중인지 점검 
			string ret1 = gweb.dBSqlite.BSTreeCCheck(SelAsset);

			if (ret1 != "")
			{
				AlertBox.Show(ret1 + "님이 방송중인 지역 입니다.", MessageBoxIcon.Information, true, ContentAlignment.MiddleCenter);
				this.comp_BBSAnchorPlayer.audioPlayerStop();
				return;
			}

			//04. 이상없이 플레이되는 경우 웹 Player 프로그램 스타트 하고 맞춰서 웹 플레이 시작 			
			this.comp_BBSAnchorPlayer.audioPlayerStart();

			// BS 방송 Status 변경
			this.comp_BBSAnchorBSStatus.setb_bsOutput(true);

			// 서버로직처리
			방송처리로직();			
		}

		private async void 방송처리로직()
		{
            /*
                        bSTreeid = gweb.dBSqlite.BSTreeGetFreeCh(SelAsset[0]);
                        if (bSTreeid == 0) return;
                        gweb.dBSqlite.BSTreeUpdate(bSTreeid, "대기");
                        gweb.dBSqlite.BSTreeCRemove(bSTreeid);
                        gweb.mainFrame.sendSigR(eSignalRMsgType.eStop, bSTreeid, null, null);
            */
            bSTreeid = gweb.dBSqlite.BSTreeGetFreeCh(SelAsset[0]);
            if (bSTreeid == 0) return;
            await gweb.dBSqlite.BSTreeCRemove(bSTreeid);
            await gweb.dBSqlite.BSTreeCSave(bSTreeid, SelAsset, SelMusic, gweb.mainFrame.user_name);
            await gweb.dBSqlite.BSTreeUpdate(bSTreeid, "방송시작");
            gweb.mainFrame.sendSigR(eSignalRMsgType.ePlay, bSTreeid, SelAsset, SelMusic);

        }

        // 1. 해당지역 서버에 중지 처리 
        // 2. 방송트리 초기화 
        // 3. 방송트리 차일드 지우기 
        private void 방송중지로직()
		{
			if (bSTreeid == 0) return;
			gweb.dBSqlite.BSTreeUpdate(bSTreeid, "대기");
			gweb.dBSqlite.BSTreeCRemove(bSTreeid);
			gweb.mainFrame.sendSigR(eSignalRMsgType.eStop, bSTreeid, null, null);
		}
	}	
}

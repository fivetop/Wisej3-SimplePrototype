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
            this.presetTableAdapter1.Fill(this.dataSet11.Preset);
            this.presetCTableAdapter1.Fill(this.dataSet11.PresetC);

            reDraw();

		}

		internal void reDraw()
		{
			setupUIComponent();

            foreach (var p1 in this.dataSet11.Preset)
            {
                Comp_PresetNameCard2 ui = new Comp_PresetNameCard2(p1);
                var t1 = PresetCGetAssets(p1.PresetId);
                var t2 = PresetCGetMusic(p1.PresetId);
                ui.EMName = t1[0].emServer;
                ui.ZoneName = t1[0].ZoneName;
                ui.MusicName = t2[0].FileName;
                ui.ZoneCount = t1.Count();
                ui.MusicCount = t2.Count();
                ui.setCardText();
                ui.ClickedEventHandler += Ui_PresetClickedEventHandler;
                this.panelList.Controls.Add(ui);
            }

        }

        // 프리셋 선택 
        int SelId = 0;
        int oldId = 0;
        private void Ui_PresetClickedEventHandler(object sender, EventArgs e)
        {
            SelId = (int)sender;
            if (SelId == 0) return;
            if (SelId == oldId) return;
            oldId = SelId;

            // 선택된 카드외에는 리셋해주고 
            foreach (Comp_PresetNameCard2 ui in panelList.Controls)
            {
                ui.setCardStatus(false);
            }
            dispDetail();
        }

        // 카드 선택을 하면 프리셋 차일드를 우측에 보여준다.
        private void dispDetail()
        {
            PresetRow r1 = gweb.dBSqlite.Ds1.Preset.FirstOrDefault(p => p.PresetId == SelId);
            comp_UGroup1.clear();
            comp_UGroup1.Filter = r1.EMNAME;
            comp_UGroup1.GroupFilter = r1.GroupName;
            comp_UGroup1.setFilter();
            comp_UGroup1.SetSelAssets(PresetCGetAssets(SelId));
            comp_UGroup1.reDraw();
            comp_BBSAnchorPlayer.SetMusic(PresetCGetMusic(SelId));
        }

        // 해당 프리셋의 차일드 가져오기 
        private List<AssetsRow> PresetCGetAssets(int id)
        {
            List<AssetsRow> list = new List<AssetsRow>();
            var rt1 = gweb.dBSqlite.Ds1.PresetC.Where(p => p.PresetId == id && p.MusicId == 0);

            foreach (var r in rt1)
            {
                var m1 = gweb.dBSqlite.Ds1.Assets.FirstOrDefault(p => p.AssetId == r.AssetId);
                if (m1 == null) continue;
                list.Add(m1);
            }
            return list;
        }

        // 해당 프리셋의 차일드 가져오기 
        private List<MusicsRow> PresetCGetMusic(int id)
        {
            List<MusicsRow> list = new List<MusicsRow>();
            var rt1 = gweb.dBSqlite.Ds1.PresetC.Where(p => p.PresetId == id && p.AssetId == 0);

            foreach (var r in rt1)
            {
                var m1 = gweb.dBSqlite.Ds1.Musics.FirstOrDefault(p => p.MusicId == r.MusicId);
                if (m1 == null) continue;
                list.Add(m1);
            }
            return list;
        }

        public void setupUIComponent()
		{
			comp_BBSAnchorBSStatus = new Comp_BBSAchchorBSStatus();
			comp_BBSAnchorPlayer = new Comp_BBSAnchorPlayer();
            comp_BBSAnchorPlayer.PlayerStarter += Comp_BBSAnchorPlayer_PlayerStarter;
            comp_BBSAnchorPlayer.PlayerStop += Comp_BBSAnchorPlayer_PlayerStop;
            comp_BBSAnchorPlayer.Dock = DockStyle.Fill;

			this.pn_BBSMonitor.Controls.Add(comp_BBSAnchorBSStatus);
			this.pn_playerList.Controls.Add(comp_BBSAnchorPlayer);
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
            SelAsset = comp_UGroup1.SelAssets(); // this.comp_BBSAnchorZone.getSelectedAssetList();
			
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

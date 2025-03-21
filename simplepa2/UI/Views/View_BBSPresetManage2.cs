﻿using simplepa2.UI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Views
{    
    public partial class View_BBSPresetManage2 : Wisej.Web.UserControl
    {
        public View_BBSPresetManage2()
        {
            InitializeComponent();

        }

        #region // init 
        private void View_BBSPresetManage2_Load(object sender, EventArgs e)
        {
            init();
        }

        public void init()
        {
            this.presetTableAdapter1.Fill(this.dataSet11.Preset);
            this.presetCTableAdapter1.Fill(this.dataSet11.PresetC);

            comp_Site1.dataSet = gweb.dBSqlite.EMServerWithWholeColLoad(1);
            comp_Site1.reDraw();
        }

        #endregion

        #region // 프리셋 선택 처리 
        // 좌측 프리셋 리스트 그리기 
        public void reDraw()
        {
            itemClear();

            foreach (var p1 in this.dataSet11.Preset)
            {
                if (p1.EMNAME != comp_Site1.selectedItem) continue;
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
                this.pn_PresetItemList.Controls.Add(ui);
            }
        }

        // 화면 클리어 
        private void itemClear()
        {
            this.pn_PresetItemList.Controls.Clear();
            pName.Text = "";
            puser_name.Text = "";
            comp_UGroup1.Filter = "";
            comp_UGroup1.GroupFilter = "";

            comp_UGroup1.clear();
            comp_Music1.clear();
            SelId = 0;
            oldId = 0;
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
            foreach(Comp_PresetNameCard2 ui in pn_PresetItemList.Controls)
            {
                ui.setCardStatus(false);
            }
            dispDetail();
        }

        // 카드 선택을 하면 프리셋 차일드를 우측에 보여준다.
        private void dispDetail()
        {
            PresetRow r1 = gweb.dBSqlite.Ds1.Preset.FirstOrDefault(p=>p.PresetId == SelId);
            pName.Text = r1.Name;
            puser_name.Text = r1.user_name;
            comp_Site1.selectedItem = r1.EMNAME;
            comp_UGroup1.Filter = r1.EMNAME;
            comp_UGroup1.GroupFilter = r1.GroupName;
             

            comp_UGroup1.clear();
            comp_Music1.clear();

            comp_UGroup1.SetSelAssets(PresetCGetAssets(SelId));
            comp_Music1.SelMusic = PresetCGetMusic(SelId);

            comp_UGroup1.reDraw();
            comp_Music1.reDraw();
        }

        // 해당 프리셋의 차일드 가져오기 
        private List<AssetsRow> PresetCGetAssets(int id)
        {
            List<AssetsRow> list = new List<AssetsRow>();
            var rt1 = gweb.dBSqlite.Ds1.PresetC.Where(p => p.PresetId == id && p.MusicId == 0);

            foreach (var r in rt1)
            {
                var m1 = gweb.dBSqlite.Ds1.Assets.FirstOrDefault(p => p.AssetId == r.AssetId);
                if(m1 == null) continue;
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

        private void comp_Site1_SelectedValueChanged(object sender, EventArgs e)
        {
            reDraw();
        }

        #endregion


        #region // add delete update

        bool add = false;
        // 추가 
        private void bt_AddPreset_Click(object sender, EventArgs e)
        {
            foreach (Comp_PresetNameCard2 ui in pn_PresetItemList.Controls)
            {
                ui.setCardStatus(false);
            }

            comp_UGroup1.clear();
            comp_Music1.clear();

            DateTime dt = DateTime.Now;
            comp_Music1.reDraw();
            comp_UGroup1.Filter = comp_Site1.selectedItem;
            comp_UGroup1.reDraw();
            pName.Text = "프리셋_" + dt.Minute.ToString("00") + dt.Second.ToString("00");
            puser_name.Text = gweb.mainFrame.user_name;
            add = true;
        }

        // 저장
        private void button2_Click(object sender, EventArgs e)
        {
            if (add)
                PresetSave();
            else
                PresetUpdate();
            reDraw();
        }

        private async void PresetUpdate()
        {
            gweb.dBSqlite.DBInit();
            if (comp_Music1.SelMusic.Count < 1 || comp_UGroup1.SelAssets().Count < 1)
            {
                AlertBox.Show("음원이나 지역이 선택 되어야 합니다.");
                return;
            }
            PresetRow r1 = await gweb.dBSqlite.PresetGet(pName.Text);
            r1.GroupName = comp_UGroup1.GroupFilter;
            await gweb.dBSqlite.PresetUpdate(r1);
            await gweb.dBSqlite.PresetCDelete(r1.PresetId);
            await gweb.dBSqlite.PresetCSave(r1, comp_Music1.SelMusic, comp_UGroup1.SelAssets());
        }

        private async void PresetSave()
        {
            gweb.dBSqlite.DBInit();
            if (await gweb.dBSqlite.PresetGet(pName.Text) != null)
            {
                AlertBox.Show("동일한 이름이 존재 합니다.");
                return;
            }

            if (comp_Music1.SelMusic.Count < 1 || comp_UGroup1.SelAssets().Count < 1)
            {
                AlertBox.Show("음원이나 지역이 선택 되어야 합니다.");
                return;
            }

            PresetRow r1 = gweb.dBSqlite.Ds1.Preset.NewPresetRow();
            r1.Name = pName.Text;
            r1.user_name = puser_name.Text;
            r1.EMNAME = comp_Site1.selectedItem;
            r1.GroupName = comp_UGroup1.GroupFilter;
            await gweb.dBSqlite.PresetSave(r1);
            PresetRow r2 = await gweb.dBSqlite.PresetGet(pName.Text);
            if (r2 == null)
            {
                AlertBox.Show("네트웍 상태를 확인 바랍니다.");
                return;
            }
            await gweb.dBSqlite.PresetCSave(r2, comp_Music1.SelMusic, comp_UGroup1.SelAssets());
        }

        // 삭제 
        private void button5_Click(object sender, EventArgs e)
        {
            if (pName.Text == "") return;

            try
            {
                if (MessageBox.Show(pName.Text + " 데이터를 삭제하시겠습니까?", 
                    icon: MessageBoxIcon.Warning, buttons: MessageBoxButtons.YesNo) == DialogResult.No) return;
                DeleteData();
                reDraw();
            }
            catch (Exception ex)
            {
            }
        }

        private async void DeleteData()
        {
            PresetRow r1 = await gweb.dBSqlite.PresetGet(pName.Text);
            if (r1 == null) return;
            if (await gweb.dBSqlite.PresetCDelete(r1.PresetId))
            { 
                await gweb.dBSqlite.PresetDelete(r1);
            }
        }
        #endregion

    }

}

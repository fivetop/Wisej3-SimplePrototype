using simplepa2.UI.Components;
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
        public void reDraw()
        {
            this.presetTableAdapter1.Fill(this.dataSet11.Preset);
            this.presetCTableAdapter1.Fill(this.dataSet11.PresetC);

            comp_Site1.dataSet = gweb.mainFrame.dBSqlite.EMServerWithWholeColLoad(1);
            comp_Site1.reDraw();
        }
        private void View_BBSPresetManage2_Load(object sender, EventArgs e)
        {
            reDraw();
            setupPresetListUI();
        }

        #endregion



        public void setupPresetListUI()
        {
            this.pn_PresetItemList.Controls.Clear();

            foreach(var preset_singleData in this.dataSet11.Preset)
            {
                Comp_PresetNameCard2 ui = new Comp_PresetNameCard2(preset_singleData);
                ui.PresetClickedEventHandler += Ui_PresetClickedEventHandler;
                this.pn_PresetItemList.Controls.Add(ui);
            }
        }

        int SelPresetId = 0;
        private void Ui_PresetClickedEventHandler(object sender, EventArgs e)
        {
            SelPresetId = (int)sender;
            if (SelPresetId == 0) return;
            // 선택된 카드외에는 리셋해주고 
            foreach(Comp_PresetNameCard2 ui in pn_PresetItemList.Controls)
            {
                ui.setCardStatus(false);
            }
            dispDetail();
        }

        private void dispDetail()
        {
            PresetRow r1 = gweb.mainFrame.dBSqlite.Ds1.Preset.FirstOrDefault(p=>p.PresetId == SelPresetId);
            pName.Text = r1.Name;
            puser_name.Text = r1.user_name;
            comp_Site1.selectedItem = r1.EMNAME;
            comp_UGroup1.GroupFilter = r1.GroupName;
            //PresetRow r2 = await gweb.mainFrame.dBSqlite.PresetSave(r1);
            //await gweb.mainFrame.dBSqlite.PresetCSave(r1, comp_Music1.SelMusic, comp_UGroup1.SelAssets);

        }

        #region // add delete update

        // 추가 
        private void bt_AddPreset_Click(object sender, EventArgs e)
        {
            foreach (Comp_PresetNameCard2 ui in pn_PresetItemList.Controls)
            {
                ui.setCardStatus(false);
            }

            DateTime dt = DateTime.Now;
            comp_Music1.reDraw();
            comp_UGroup1.Filter = comp_Site1.selectedItem;
            comp_UGroup1.reDraw();
            pName.Text = "프리셋_" + dt.Minute.ToString("00") + dt.Second.ToString("00");
            puser_name.Text = gweb.mainFrame.user_name;
        }

        // 저장
        private void button2_Click(object sender, EventArgs e)
        {
            PresetSave();
        }

        private async void PresetSave()
        {
            gweb.mainFrame.dBSqlite.DBInit();
            if (await gweb.mainFrame.dBSqlite.PresetGet(pName.Text))
            {
                AlertBox.Show("동일한 이름이 존재 합니다.");
                return;
            }

            if (comp_Music1.SelMusic.Count < 1 || comp_UGroup1.SelAssets.Count < 1)
            {
                AlertBox.Show("음원이나 지역이 선택 되어야 합니다.");
                return;
            }

            PresetRow r1 = gweb.mainFrame.dBSqlite.Ds1.Preset.NewPresetRow();
            r1.Name = pName.Text;
            r1.user_name = puser_name.Text;
            r1.EMNAME = comp_Site1.selectedItem;
            r1.GroupName = comp_UGroup1.GroupFilter;
            PresetRow r2 = await gweb.mainFrame.dBSqlite.PresetSave(r1);
            if (r2 == null)
            {
                AlertBox.Show("네트웍 상태를 확인 바랍니다.");
                return;
            }
            await gweb.mainFrame.dBSqlite.PresetCSave(r2, comp_Music1.SelMusic, comp_UGroup1.SelAssets);
        }

        // 삭제 
        private void button5_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }

}

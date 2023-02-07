using simplepa2.UI.Components;
using System;
using System.Collections.Generic;
using Wisej.Web;

namespace simplepa2.UI.Views
{    
    public partial class View_BBSPresetManage2 : Wisej.Web.UserControl
    {
        public View_BBSPresetManage2()
        {
            InitializeComponent();

        }

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

        private void Ui_PresetClickedEventHandler(object sender, EventArgs e)
        {
/*
            int selectedPresetNo = (sender as Comp_PresetNameCard2).intCardNo;
            // 선택된 카드외에는 리셋해주고 
            foreach(Comp_PresetNameCard ui in preset_NameCardList)
            {
                if(ui.intCardNo != selectedPresetNo)
                {
                    ui.setCardStatus(false);
                }                
            }
*/
        }

        private void bt_AddPreset_Click(object sender, EventArgs e)
        {
            comp_Music1.reDraw();
            comp_UGroup1.Filter = comp_Site1.selectedItem;
            comp_UGroup1.reDraw();
        }
    }

}

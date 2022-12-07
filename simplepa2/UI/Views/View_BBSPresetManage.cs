using simplepa2.UI.Components;
using System;
using System.Collections.Generic;
using Wisej.Web;

namespace simplepa2.UI.Views
{    
    public partial class View_BBSPresetManage : Wisej.Web.UserControl
    {
        private List<Preset_DataList> preset_DataList;
        private List<Comp_PresetNameCard> preset_NameCardList;

        public View_BBSPresetManage()
        {
            InitializeComponent();

            // TODO : getDataFromDataBase of preset datalist 
            preset_DataList = demoDataSetup();

            // UI Name Card SETUP
            preset_NameCardList = setupPresetListUI(preset_DataList);

        }

        public List<Comp_PresetNameCard> setupPresetListUI(List<Preset_DataList> dataList)
        {
            if (dataList == null)
            {
                this.pn_PresetItemList.Controls.Clear();
                return null;
            }

            List < Comp_PresetNameCard > uiSet = new List < Comp_PresetNameCard >();
            
            foreach(Preset_DataList preset_singleData in dataList)
            {
                Comp_PresetNameCard ui = new Comp_PresetNameCard(preset_singleData);
                ui.presetClick += new Comp_PresetNameCard.PresetClickedEventHandler(this.presetCardClick);
                uiSet.Add(ui);
            }

            foreach(Comp_PresetNameCard ui in uiSet)
            {
                this.pn_PresetItemList.Controls.Add(ui);
                this.pn_PresetItemList.Controls.Add(new Comp_GroupNameSpacer());

            }

            return uiSet;
        }

        public void presetCardClick(object sender, PresetClickedEventArgs args)
        {
            int selectedPresetNo = (sender as Comp_PresetNameCard).getPresetID();

            // 선택된 카드외에는 리셋해주고 
            foreach(Comp_PresetNameCard ui in preset_NameCardList)
            {
                if(ui.getPresetID() != selectedPresetNo)
                {
                    ui.setCardStatus(false);
                }                
            }

            // TODO : DB에서 데이터를 받아 선택된 카드의 Preset 데이터를 로딩함 
            this.pn_PresetDetails.Controls.Clear();
            this.pn_PresetDetails.Controls.Add(new Comp_PresetDetailPanel());
        }

        public List<Preset_DataList> demoDataSetup()
        {
            List<Preset_DataList> dList = new List<Preset_DataList>();

            Preset_DataList data1 = new Preset_DataList();
            data1.intPresetID = 1;
            data1.strPresetName = "프리셋1번";
            data1.strPresetSite = "오크동";
            data1.strSelectAreaCount = "23개 지역";
            data1.strPresetImageName = "Images/icon-ls-004.png";
            dList.Add(data1);

            Preset_DataList data2 = new Preset_DataList();
            data2.intPresetID = 2;
            data2.strPresetName = "프리셋2번";
            data2.strPresetSite = "오크동";
            data2.strSelectAreaCount = "21개 지역";
            data2.strPresetImageName = "Images/icon-ls-001.png";
            dList.Add(data2);

            Preset_DataList data3 = new Preset_DataList();
            data3.intPresetID = 3;
            data3.strPresetName = "프리셋3번";
            data3.strPresetSite = "오크동";
            data3.strSelectAreaCount = "22개 지역";
            data3.strPresetImageName = "Images/icon-ls-002.png";
            dList.Add(data3);

            Preset_DataList data4 = new Preset_DataList();
            data4.intPresetID = 4;
            data4.strPresetName = "프리셋4번";
            data4.strPresetSite = "오크동";
            data4.strSelectAreaCount = "15개 지역";
            data4.strPresetImageName = "Images/icon-ls-003.png";
            dList.Add(data4);

            Preset_DataList data5 = new Preset_DataList();
            data5.intPresetID = 5;
            data5.strPresetName = "프리셋5번";
            data5.strPresetSite = "오크동";
            data5.strSelectAreaCount = "15개 지역";
            data5.strPresetImageName = "Images/icon-ls-003.png";
            dList.Add(data5);

            Preset_DataList data6 = new Preset_DataList();
            data6.intPresetID = 6;
            data6.strPresetName = "프리셋6번 테스트 지역";
            data6.strPresetSite = "스키리조트";
            data6.strSelectAreaCount = "3개 지역";
            data6.strPresetImageName = "Images/icon-ls-003.png";
            dList.Add(data6);

            return dList;
        }
    }

    public class Preset_DataList
    {
        public int intPresetID;
        public string strPresetName;
        public string strPresetSite;
        public string strSelectAreaCount;
        public string strPresetImageName;
    }
}

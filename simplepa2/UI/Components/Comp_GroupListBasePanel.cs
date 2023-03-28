using System;
using System.Collections.Generic;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Components
{
    public partial class Comp_GroupListBasePanel : Wisej.Web.UserControl
    {
        public List<Group_DataPack> group_data = new List<Group_DataPack>();  // GroupList       

        public List<Comp_GroupNameCard> group_UI_Cardlist = new List<Comp_GroupNameCard>();  // Group UI List

        public event CompBBSGroupListClickedEventHandler GroupCardClicked;
        public delegate void CompBBSGroupListClickedEventHandler(object sender, CompBBSGroupListClickedEventArgs e);

        public Comp_GroupListBasePanel()
        {
            InitializeComponent();
        }

        private void Comp_GroupListBasePanel_Load(object sender, EventArgs e)
        {

        }

        public List<Group_DataPack> preProcessingDataFormatForGroupList(AssetGroupListDataTable groupDt)
        {
            List<Group_DataPack> groupList_Temp = new List<Group_DataPack>();            

            for (int i = 0; i < groupDt.Count; i++)  // data Pack to List 
            {
                Group_DataPack gDt = new Group_DataPack();                
                
                if (int.TryParse(groupDt.Rows[i]["regionCount"].ToString(), out gDt.intRegionCount))
                {
                    // True 인 경우 없음
                }
                else
                {
                    gDt.intRegionCount = 0;
                }
                
                gDt.strGroupName = groupDt.Rows[i]["groupName"].ToString(); ;
                gDt.intGroupIndex = int.Parse(groupDt.Rows[i]["groupNo"].ToString()) ;

                groupList_Temp.Add(gDt);
            }

            return groupList_Temp;            
        }

        public void setupGroupListUI(AssetGroupListDataTable groupDt)
        {
            this.group_data = preProcessingDataFormatForGroupList(groupDt);

            this.Controls.Clear();   // UI stack clear 
            this.group_UI_Cardlist.Clear();  // UI pointer list clear

            if (group_data.Count == 0)
            {                
                return;
            }            

            foreach (Group_DataPack data in group_data)
            {
                Comp_GroupNameCard card = new Comp_GroupNameCard(data.strGroupName, data.intGroupIndex, data.intRegionCount, false);
                card.groupClick += new Comp_GroupNameCard.GroupClickedEventHandler(this.groupCard_Clicked);

                group_UI_Cardlist.Add(card);
            }

            foreach(Comp_GroupNameCard data in group_UI_Cardlist)
            {
                this.Controls.Add(data);
                this.Controls.Add(new Comp_GroupNameSpacer());
            }
            
        }


        public void groupCard_Clicked(object sender, GroupClickedEventArgs args)
        {

            // 선택된 카드 찾고
            int selectedCardNo = (sender as Comp_GroupNameCard).intCardNo;


            // 기 선택 카드 언셀렉트 시키고
            foreach (Comp_GroupNameCard card in group_UI_Cardlist)
            {
                if (selectedCardNo != card.intCardNo && card.cardClicked == true )  // 현재 선택된 카드와 번호가 같지 않고 클릭이 된상태의 것
                {
                    card.setCardStatus(false);
                }
            }

            // View로 이벤트 던지기
            GroupCardClicked(this, new CompBBSGroupListClickedEventArgs(args.groupName));            

        }



        #region demo 용 


        public List<Group_DataPack> demo_GroupData()
        {
            List<Group_DataPack> dataList = new List<Group_DataPack>();

            Group_DataPack gd = new Group_DataPack();
            gd.siteName = "오크동";
            gd.strGroupName = "오크동 1번 그룹";
            gd.strGroupImage = "xxx.jpg";
            gd.intGroupIndex = 1;
            dataList.Add(gd);

            Group_DataPack gd2 = new Group_DataPack();
            gd2.siteName = "오크동";
            gd2.strGroupName = "오크동 2번 그룹";
            gd2.strGroupImage = "xxx.jpg";
            gd2.intGroupIndex = 2;
            dataList.Add(gd2);


            Group_DataPack gd3 = new Group_DataPack();
            gd3.siteName = "오크동";
            gd3.strGroupName = "오크동3번 그룹";
            gd3.strGroupImage = "xxx.jpg";
            gd3.intGroupIndex = 3;
            dataList.Add(gd3);

            Group_DataPack gd4 = new Group_DataPack();
            gd4.siteName = "오크동";
            gd4.strGroupName = "오크동 4번 그룹";
            gd4.strGroupImage = "xxx.jpg";
            gd4.intGroupIndex = 4;
            dataList.Add(gd4);


            Group_DataPack gd5 = new Group_DataPack();
            gd5.siteName = "오크동";
            gd5.strGroupName = "오크동 5번 그룹";
            gd5.strGroupImage = "xxx.jpg";
            gd5.intGroupIndex = 5;
            dataList.Add(gd5);

            Group_DataPack gd6 = new Group_DataPack();
            gd6.siteName =
            gd6.strGroupName = "오크동 6번 그룹";
            gd6.strGroupImage = "xxx.jpg";
            gd6.intGroupIndex = 6;
            dataList.Add(gd6);

            Group_DataPack gd7 = new Group_DataPack();
            gd7.siteName = "오크동";
            gd7.strGroupName = "오크동 7번 그룹";
            gd7.strGroupImage = "xxx.jpg";
            gd7.intGroupIndex = 7;
            dataList.Add(gd7);

            Group_DataPack gd8 = new Group_DataPack();
            gd8.siteName = "오크동";
            gd8.strGroupName = "오크동 8번 그룹";
            gd8.strGroupImage = "xxx.jpg";
            gd8.intGroupIndex = 8;
            dataList.Add(gd8);

            Group_DataPack gd9 = new Group_DataPack();
            gd9.siteName = "오크동";
            gd9.strGroupName = "오크동 9번 그룹";
            gd9.strGroupImage = "xxx.jpg";
            gd9.intGroupIndex = 9;
            dataList.Add(gd9);

            Group_DataPack gd10 = new Group_DataPack();
            gd10.siteName = "오크동";
            gd10.strGroupName = "오크동 10번 그룹";
            gd10.strGroupImage = "xxx.jpg";
            gd10.intGroupIndex = 10;
            dataList.Add(gd10);

            return dataList;
        }

        public List<Group_DataPack> getGroupListFromDBBySiteName(string siteName)
        {
            List<Group_DataPack> groupReturnPack;

            // TODO : DB Connection below is demo connection
            if (siteName.Equals("오크동"))
            {
                groupReturnPack = demo_GroupData();
            }
            else
            {
                groupReturnPack = null;
            }
            // -- for those for the demonstartion UI 

            if (groupReturnPack == null)
                return null;


            return groupReturnPack;
        }

        #endregion 
    }


    public class Group_DataPack
    {
        public string siteName;
        public string strGroupName;
        public string strGroupImage;

        public int intRegionCount;
        public int intGroupIndex;
    }

    public class CompBBSGroupListClickedEventArgs : EventArgs
    {
        internal CompBBSGroupListClickedEventArgs(string groupName)
        {
            this.groupName = groupName;
        }

        public string groupName
        {
            get;
            private set;
        }
    }

}

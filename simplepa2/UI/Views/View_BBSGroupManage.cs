using simplepa2.UI.Components;
using System;
using System.Collections.Generic;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBSGroupManage : Wisej.Web.UserControl
    {
        public List<Group_DataList> group_data;     // GroupList
        public Object[] site_list;  // Site List     
        public List<Comp_GroupNameCard> group_UI_list;


    public View_BBSGroupManage()
        {
            InitializeComponent();

            // 01. Combo Box Setup 
            this.cb_SiteName.Items.AddRange(getSiteListFromDBByUser("admin"));
            this.cb_SiteName.SelectedIndex = 0;

            // 02. Group List Call and Setup // l로그인 유저는 추가 변경 필요 
            group_data = getGroupListFromDBBySiteName(cb_SiteName.Text);

            setupGroupListUI(group_data);

        }

        public Object[] getSiteListFromDBByUser(string username)
        {
            // TODO : DB Connection and get Data from DB 
            Object[] getData = new Object[] { "오크동", "대명리조트본관", "오션월드", "스키센터", "호텔동" };
            return getData;
        }
        public List<Group_DataList> getGroupListFromDBBySiteName(string siteName)
        {
            List<Group_DataList> groupReturnPack;

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

        public void setupGroupListUI(List<Group_DataList> dataList)
        {
            if(dataList == null)
            {
                this.pn_GroupList.Controls.Clear();
                return;
            }
            if(group_UI_list != null)
                group_UI_list.Clear();  // 기존 리스트 삭제 

            group_UI_list = new List<Comp_GroupNameCard>();  // 신규 UI 관리 리스트 빌드

            foreach (Group_DataList data in dataList)
            {
                Comp_GroupNameCard card = new Comp_GroupNameCard(data.strGroupName, data.intGroupIndex, false);
                card.groupClick += new Comp_GroupNameCard.GroupClickedEventHandler(this.groupCard_Clicked);
                    
                group_UI_list.Add(card);
            }

            foreach(Comp_GroupNameCard card in group_UI_list)
            {
                this.pn_GroupList.Controls.Add(card);
                this.pn_GroupList.Controls.Add(new Comp_GroupNameSpacer());
            }
        }

        public void groupCard_Clicked(object sender, GroupClickedEventArgs args)
        {
            
            // 선택된 카드 찾고
            int selectedCardNo = (sender as Comp_GroupNameCard).intCardNo;


            // 아닌거 취소 시키고
            foreach (Comp_GroupNameCard card in group_UI_list)
            {
                if(selectedCardNo != card.intCardNo)
                {
                    card.setCardStatus(false);
                }
            }

            // 선택된 카드의 데이터 로드 해주고
            this.pn_GroupDetails.Controls.Clear();
            this.pn_GroupDetails.Controls.Add(new Comp_GroupDetailPanel());

        }

        private void cb_SiteName_SelectedIndexChanged(object sender, EventArgs e)
        {
            group_data = getGroupListFromDBBySiteName(cb_SiteName.Text);
            setupGroupListUI(group_data);

        }


        public List<Group_DataList> demo_GroupData()
        {
            List<Group_DataList> dataList = new List<Group_DataList>();

            Group_DataList gd = new Group_DataList();
            gd.siteName = "오크동";
            gd.strGroupName = "오크동 1번 그룹";
            gd.strGroupImage = "xxx.jpg";
            gd.intGroupIndex = 1;
            dataList.Add(gd);

            Group_DataList gd2 = new Group_DataList();
            gd2.siteName = "오크동";
            gd2.strGroupName = "오크동 2번 그룹";
            gd2.strGroupImage = "xxx.jpg";
            gd2.intGroupIndex = 2;
            dataList.Add(gd2);


            Group_DataList gd3 = new Group_DataList();
            gd3.siteName = "오크동";
            gd3.strGroupName = "오크동3번 그룹";
            gd3.strGroupImage = "xxx.jpg";
            gd3.intGroupIndex =3;
            dataList.Add(gd3);

            Group_DataList gd4 = new Group_DataList();
            gd4.siteName = "오크동";
            gd4.strGroupName = "오크동 4번 그룹";
            gd4.strGroupImage = "xxx.jpg";
            gd4.intGroupIndex = 4;
            dataList.Add(gd4);


            Group_DataList gd5 = new Group_DataList();
            gd5.siteName = "오크동";
            gd5.strGroupName = "오크동 5번 그룹";
            gd5.strGroupImage = "xxx.jpg";
            gd5.intGroupIndex = 5;
            dataList.Add(gd5);

            Group_DataList gd6 = new Group_DataList();
            gd6.siteName = 
            gd6.strGroupName = "오크동 6번 그룹";
            gd6.strGroupImage = "xxx.jpg";
            gd6.intGroupIndex = 6;
            dataList.Add(gd6);

            Group_DataList gd7 = new Group_DataList();
            gd7.siteName = "오크동";
            gd7.strGroupName = "오크동 7번 그룹";
            gd7.strGroupImage = "xxx.jpg";
            gd7.intGroupIndex = 7;
            dataList.Add(gd7);

            Group_DataList gd8 = new Group_DataList();
            gd8.siteName = "오크동";
            gd8.strGroupName = "오크동 8번 그룹";
            gd8.strGroupImage = "xxx.jpg";
            gd8.intGroupIndex = 8;
            dataList.Add(gd8);

            Group_DataList gd9 = new Group_DataList();
            gd9.siteName = "오크동";
            gd9.strGroupName = "오크동 9번 그룹";
            gd9.strGroupImage = "xxx.jpg";
            gd9.intGroupIndex = 9;
            dataList.Add(gd9);

            Group_DataList gd10 = new Group_DataList();
            gd10.siteName = "오크동";
            gd10.strGroupName = "오크동 10번 그룹";
            gd10.strGroupImage = "xxx.jpg";
            gd10.intGroupIndex = 10;
            dataList.Add(gd10);

            return dataList;
        }

    }

    public class Group_DataList
    {
        public string siteName;
        public string strGroupName;
        public string strGroupImage;
        public int intGroupIndex;
    }

    
}

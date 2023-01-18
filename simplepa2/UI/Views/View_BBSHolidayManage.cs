using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Xml;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBSHolidayManage : Wisej.Web.UserControl
    {
        public int selectedHolidayID = 0;

        private DataSet1.HolidaysDivideDateRow holidayData = null;
        public View_BBSHolidayManage()
        {
            InitializeComponent();
        }

        public void reDraw()
        {
            holidayDataLoad();

            comboSetup();
        }

        public void holidayDataLoad()
        {            
            this.holidaysDivideDateTableAdapter1.Fill(dataSet11.HolidaysDivideDate);

            dg_holidayList.DataSource = dataSet11.HolidaysDivideDate;          
     
        }
        public void comboSetup()
        {
            this.holidaysYearListTableAdapter1.Fill(dataSet11.HolidaysYearList);

            cb_year.DataSource = dataSet11.HolidaysYearList;

            this.cb_year.SelectedIndex = 0;

            this.cb_monthAPI.SelectedIndex = 0;
        }

        private void cb_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (((this.cb_year.SelectedItem as DataRowView).Row) as DataSet1.HolidaysYearListRow).Yearlist;

            if(selectedItem.Equals("All"))
            {
                dg_holidayList.DataSource = dataSet11.HolidaysDivideDate;
            }
            else
            {
                dg_holidayList.DataSource = dataSet11.HolidaysDivideDate.Select("Year = '" + selectedItem + "'");
            }

        }

        private void bt_gonggongUpdate_Click(object sender, EventArgs e)
        {            
            string callMonth = cb_monthAPI.SelectedItem.ToString();
            AlertBox.Show("공공 데이터로 부터 " + callMonth + "월의 휴일 데이터를 받아 옵니다.");

            this.ShowLoader = true;

            try
            {
       

                if(callMonth.Equals("All"))
                {
                    for(int i=1; i < 13; i++)
                    {
                        // 데이터 받아오기
                        getAPI(i.ToString());
                    }

                }
                else
                {
                    // 데이터 받아오기
                    getAPI(callMonth);
                }                           

            } catch(Exception e1)
            {
                MessageBox.Show("예외 발생 - 메시지 : " + e1.ToString());
            }

            // 데이터 다시 로드
            holidayDataLoad();

            this.ShowLoader = false;
        }

        private void dg_holidayList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            lb_text.Text = "휴일 편집";
            bt_updateoradd.Text = "업데이트";

            var dgv = (DataGridView)sender;
            var r1 = dgv.Rows[e.RowIndex];
            holidayData = (r1.DataBoundItem as DataRowView).Row as DataSet1.HolidaysDivideDateRow;

            this.dt_picker.Value = holidayData.hDate;
            this.tb_holidayDescription.Text = holidayData.Description;
            this.selectedHolidayID = holidayData.HolidayId;

            this.bt_delete.Visible = true;

        }

        private void bt_updateoradd_Click(object sender, EventArgs e)
        {
            if(this.selectedHolidayID == 0)   // 0 이면 신규 
            {
                this.holidaysTableAdapter1.InsertUpdateQuery(dt_picker.Value.Date, tb_holidayDescription.Text);                    
                AlertBox.Show("데이터를 저장 하였습니다.");
 
            }
            else // 아니면 Grid 에서 선택된 ID 가 있음 
            {
                this.holidayData.hDate = dt_picker.Value.Date;
                this.holidayData.Description = tb_holidayDescription.Text;
                this.holidaysTableAdapter1.InsertUpdateQuery(dt_picker.Value.Date, tb_holidayDescription.Text);                
                AlertBox.Show("데이터를 업데이트 하였습니다.");
            }

            // UI 초기화 
            this.dt_picker.Value = DateTime.Now;
            this.tb_holidayDescription.Text = "";
            this.selectedHolidayID = 0;

            // 데이터 다시 로드
            holidayDataLoad();            
        }

        // 국가 공공 디비 엑세스 처리 
        public void getAPI(string selectedMonth)
        {   
            string url1 = "http://apis.data.go.kr/B090041/openapi/service/SpcdeInfoService/getRestDeInfo?solYear=";  //테스트 사이트
            string url2 = "2020&solMonth=01&ServiceKey=";
            string url3 = "mLJH5Eeoqb7OTFroSUQamOhICUf7Tu4RRoAMTRUUzdccLYnOjHbe6MjfutDcjFrRGNUp2qG3lrG1hMDk0V%2FbSQ%3D%3D";  //테스트 사이트

            string responseText = string.Empty;
            string url = url1 + url2 + url3;

            DateTime t1 = DateTime.Now;

            int getMonth = Convert.ToInt16(selectedMonth);

            if(getMonth > 9)
            {
                url2 = t1.Year.ToString() + "&solMonth=" + selectedMonth + "&ServiceKey=";                
            }
            else if(getMonth < 10)
            {
                url2 = t1.Year.ToString() + "&solMonth=" + "0" + selectedMonth + "&ServiceKey=";                
            }

            url = url1 + url2 + url3;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Timeout = 30 * 1000; // 30초

            using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
            {
                HttpStatusCode status = resp.StatusCode;
                Stream respStream = resp.GetResponseStream();

                using (StreamReader sr = new StreamReader(respStream))
                {
                    responseText = sr.ReadToEnd();
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(responseText);  

                    XmlNodeList lstVideos = doc.DocumentElement.ChildNodes;
                    XmlNode obj1 = doc["response"]["body"]["items"];                    

                    foreach (XmlNode obj2 in obj1.ChildNodes)
                    {
                        var dateName = obj2["dateName"].InnerText;
                        var dateKind = obj2["dateKind"].InnerText;
                        var locdate = obj2["locdate"].InnerText;                        
                        int day1 = int.Parse(locdate.Substring(6, 2));
                        int month1 = int.Parse(locdate.Substring(4, 2));

                        DateTime dt2 = new DateTime(t1.Year, month1, day1);


                        try {
                            this.holidaysTableAdapter1.InsertUpdateQuery(dt2, dateName);
                        } catch (Exception e1)
                        {
                            MessageBox.Show("LAWTEXT : 데이터를 동기화하는 중 예외가 발생 하였습니다.   Message" + e1.ToString());
                            return;
                        }
                    }
                }                
            }
        }

        private void bt_openAddNewForm_Click(object sender, EventArgs e)
        {
            lb_text.Text = "신규 휴일";
            bt_updateoradd.Text = "신규추가";

            // 선택된 데이터 삭제
            this.holidayData = null;

            // UI 초기화 
            this.dt_picker.Value = DateTime.Now;
            this.tb_holidayDescription.Text = "";
            this.selectedHolidayID = 0;
            this.bt_delete.Visible = false;

            // Grid 초기화 
            this.dg_holidayList.ClearSelection();
        }


        private void bt_delete_Click(object sender, EventArgs e)
        {
            var row = dg_holidayList.SelectedRows;
            this.holidaysDivideDateTableAdapter1.Delete(holidayData.hDate);

            holidayDataLoad();
        }

        private void View_BBSHolidayManage_Load(object sender, EventArgs e)
        {
            reDraw();
        }
    }
}

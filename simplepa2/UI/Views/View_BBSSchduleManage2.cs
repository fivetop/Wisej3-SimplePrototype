using DataClass;
using simplepa2.Controller;
using simplepa2.UI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Views
{    
    public partial class View_BBSSchduleManage2 : Wisej.Web.UserControl
    {
        TimeSpace timeSpace = new TimeSpace();
        public View_BBSSchduleManage2()
        {
            InitializeComponent();

        }

        #region // init 
        private void View_BBSSchduleManage2_Load(object sender, EventArgs e)
        {
            init();
            comp_Music1.eventMusicDuration += Comp_Music1_eventMusicDuration;
        }

        public void init()
        {
            this.schduleTableAdapter1.Fill(this.dataSet11.Schdule);
            this.schduleCTableAdapter1.Fill(this.dataSet11.SchduleC);

            comp_Site1.dataSet = gweb.dBSqlite.EMServerWithWholeColLoad(1);
            comp_Site1.reDraw();
        }

        #endregion

        #region // 예약방송 선택 처리 
        // 좌측 예약방송 리스트 그리기 
        public void reDraw()
        {
            itemClear();

            this.schduleTableAdapter1.Fill(this.dataSet11.Schdule);

            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = schduleBindingSource;
            button저장.Visible = false;

            foreach (var Schdule_singleData in this.dataSet11.Schdule)
            {
            }
        }

        // 화면 클리어 
        private void itemClear()
        {
            check주간반복.Checked = true;
            panel특정일자.Visible = false;
            dateTime일자.Value = DateTime.Now;
            masked시작시간.Text = "00:00";
            masked종료시간.Text = "00:00";

            pName.Text = "";
            puser_name.Text = "";

            comp_UGroup1.Filter = "";
            comp_UGroup1.GroupFilter = "";

            comp_UGroup1.clear();
            comp_Music1.clear();
            SelSchduleId = 0;
            oldSelSchduleId = 0;
        }

        // 예약방송 선택 
        int SelSchduleId = 0;
        int oldSelSchduleId = 0;

        // 카드 선택을 하면 예약방송 차일드를 우측에 보여준다.
        private void dispDetail()
        {
            SchduleRow r1 = gweb.dBSqlite.Ds1.Schdule.FirstOrDefault(p=>p.SchduleId == SelSchduleId);
            pName.Text = r1.Name;
            puser_name.Text = r1.user_name;
            comp_Site1.selectedItem = r1.EMNAME;
            comp_UGroup1.Filter = r1.EMNAME;
            comp_UGroup1.GroupFilter = r1.GroupName;

            masked시작시간.Text = r1.stime.ToString("HH:mm");
            masked종료시간.Text = r1.etime.ToString("HH:mm");
            dateTime일자.Value = r1.sdate;
            r1.day1 = check월.Checked = r1.day1;
            r1.day2 = check화.Checked = r1.day2;
            r1.day3 = check수.Checked = r1.day3;
            r1.day4 = check목.Checked = r1.day4;
            r1.day5 = check금.Checked = r1.day5;
            r1.day6 = check토.Checked = r1.day6;
            r1.day7 = check일.Checked = r1.day7;
            check주간반복.Checked = r1.week;

            if (r1.week)
            {
                panel특정일자.Visible = false;
                panel주간.Visible = true;
            }
            else
            {
                panel특정일자.Visible = true;
                panel주간.Visible = false;
            }

            comp_UGroup1.clear();
            comp_Music1.clear();

            comp_UGroup1.SetSelAssets(SchduleCGetAssets());
            comp_Music1.SelMusic = SchduleCGetMusic();

            comp_UGroup1.reDraw();
            comp_Music1.reDraw();
        }

        // 해당 예약방송의 차일드 가져오기 
        private List<AssetsRow> SchduleCGetAssets()
        {
            List<AssetsRow> list = new List<AssetsRow>();
            var rt1 = gweb.dBSqlite.Ds1.SchduleC.Where(p => p.SchduleId == SelSchduleId && p.MusicId == 0);

            foreach (var r in rt1)
            {
                var m1 = gweb.dBSqlite.Ds1.Assets.FirstOrDefault(p => p.AssetId == r.AssetId);
                if(m1 == null) continue;
                list.Add(m1);
            }
            return list;
        }

        // 해당 예약방송의 차일드 가져오기 
        private List<MusicsRow> SchduleCGetMusic()
        {
            List<MusicsRow> list = new List<MusicsRow>();
            var rt1 = gweb.dBSqlite.Ds1.SchduleC.Where(p => p.SchduleId == SelSchduleId && p.AssetId == 0);

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
            string site = comp_Site1.selectedItem;

            string f2 = "EMNAME='" + site + "'";
            schduleBindingSource.Filter = f2;

            reDraw();
        }

        private void Comp_Music1_eventMusicDuration(object sender, EventArgs e)
        {
            string t1 = sender as string;
            maskedDuration.Text = t1;

            TimeSpan st = new TimeSpan();
            TimeSpan.TryParseExact(masked시작시간.Text, @"hh\:mm", null, out st);
            TimeSpan et = new TimeSpan();
            TimeSpan.TryParseExact(maskedDuration.Text, @"hh\:mm", null, out et);

            et = st + et;
            masked종료시간.Text = et.ToString(@"hh\:mm");
        }


        #endregion


        #region // add delete update

        // 추가 
        private void bt_AddSchdule_Click(object sender, EventArgs e)
        {
            comp_UGroup1.clear();
            comp_Music1.clear();

            DateTime dt = DateTime.Now;
            comp_Music1.reDraw();
            comp_UGroup1.Filter = comp_Site1.selectedItem;
            comp_UGroup1.reDraw();
            pName.Text = "예약방송_" + dt.Minute.ToString("00") + dt.Second.ToString("00");
            puser_name.Text = "홍길동";
            button저장.Visible = true;
        }

        // 저장
        private void button2_Click(object sender, EventArgs e)
        {
            timeSpace.makeDB();
            if (SchduleSave().Result == true)
            { 
                reDraw();
            }
        }

        private async Task<bool> SchduleSave()
        {
            if (await gweb.dBSqlite.SchduleGet(pName.Text) != null)
            {
                AlertBox.Show("동일한 이름이 존재 합니다.");
                return false;
            }

            if (comp_Music1.SelMusic.Count < 1 || comp_UGroup1.SelAssets().Count < 1)
            {
                AlertBox.Show("음원이나 지역이 선택 되어야 합니다.");
                return false;
            }

            SchduleRow r1 = gweb.dBSqlite.Ds1.Schdule.NewSchduleRow();
            r1.Name = pName.Text;
            r1.user_name = puser_name.Text;
            r1.EMNAME = comp_Site1.selectedItem;
            r1.GroupName = comp_UGroup1.GroupFilter;

            r1.sdate = dateTime일자.Value.Date; 
            r1.day1 = check월.Checked;
            r1.day2 = check화.Checked;
            r1.day3 = check수.Checked;
            r1.day4 = check목.Checked;
            r1.day5 = check금.Checked;
            r1.day6 = check토.Checked;
            r1.day7 = check일.Checked;
            r1.week = check주간반복.Checked;

            r1.tss = masked시작시간.Text;
            r1.tse = masked종료시간.Text;

            TimeSpan st = new TimeSpan();
            TimeSpan.TryParseExact(masked시작시간.Text, @"hh\:mm", null, out st);
            TimeSpan et = new TimeSpan();
            TimeSpan.TryParseExact(masked종료시간.Text, @"hh\:mm", null, out et);

            r1.stime = r1.sdate + st;
            r1.etime = r1.sdate + et;
            r1.duration = comp_Music1.GetDuration(); 
            r1.chno = 4;
            r1.state = "방송대기";

            // 방송 시간과 지역을 갖고 사용중인지 점검 하기 
            if (CheckTimeSpace(r1) == false) 
                return false;

            await gweb.dBSqlite.SchduleSave(r1);
            SchduleRow r2 = await gweb.dBSqlite.SchduleGet(pName.Text);
            if (r2 == null)
            {
                MessageBox.Show("네트웍 상태를 확인 바랍니다.");
                return false;
            }
            await gweb.dBSqlite.SchduleCSave(r2, comp_Music1.SelMusic, comp_UGroup1.SelAssets());
            gweb.mainFrame.sendSigR(eSignalRMsgType.eScheduleDown);
            return true;
        }

        private bool CheckTimeSpace(SchduleRow r1)
        {
            timeSpace.multi.schduleC.Clear();
            timeSpace.multi = new SchduleMem();
            SchduleMem multi = timeSpace.multi;

            multi.Name = r1.Name;
            multi.user_name = r1.user_name;
            multi.EMNAME = r1.EMNAME;
            multi.GroupName = r1.GroupName;

            multi.week = r1.week;
            multi.chno = r1.chno;

            multi.sdate = r1.sdate;
            multi.tss = r1.tss;
            multi.tse = r1.tse;
            multi.stime = r1.stime;
            multi.etime = r1.etime;
            multi.duration = r1.duration;// txtEndTime.Text;

            TimeSpan st = new TimeSpan();
            TimeSpan.TryParseExact(multi.tss, @"hh\:mm", null, out st);
            TimeSpan et = new TimeSpan();
            TimeSpan.TryParseExact(multi.tse, @"hh\:mm", null, out et);
            multi.tss1 = st;
            multi.tse1 = et;

            multi.day1 = r1.day1;
            multi.day2 = r1.day2;
            multi.day3 = r1.day3;
            multi.day4 = r1.day4;
            multi.day5 = r1.day5;
            multi.day6 = r1.day6;
            multi.day7 = r1.day7;

            var t2 = comp_UGroup1.SelAssets();

            foreach (var t1 in t2)
            {
                SchduleC s1 = new SchduleC();
                s1.AssetId = t1.AssetId;
                multi.schduleC.Add(s1);
            }

            timeSpace.dbrlt.Clear();

            if (multi.week == true)
            {
                timeSpace.SearchDBSch();
                if (timeSpace.CheckDay() == false)
                {
                    // 요일 중복이며 공간도 동일한가?
                    if (timeSpace.CheckSpace() == false)
                    {
                        MessageBox.Show("해당시간에 사용중인 지역 입니다.1 : NO : " + timeSpace.errString);
                        return false;
                    }
                }

                // 해당 디비에서 임의의 공간이 중복 되었는가?
                timeSpace.SearchDBweek();
                if (timeSpace.CheckSpace() == false)
                {
                    MessageBox.Show("해당시간에 사용중인 지역 입니다.2 : NO : " + timeSpace.errString);
                    return false;
                }

            }
            else
            {
                // 정규에 중복된 요일이 존재 하는가?
                timeSpace.SchSearchDBweek();
                // 해당 디비에서 임의의 공간이 중복 되었는가?
                if (timeSpace.CheckSpace() == false)
                {
                    MessageBox.Show("해당시간에 사용중인 지역 입니다.3 : NO : " + timeSpace.errString);
                    return false;
                }

                timeSpace.SchSearchDB();
                // 해당 디비에서 임의의 공간이 중복 되었는가?
                if (timeSpace.CheckSpace() == false)
                {
                    MessageBox.Show("해당시간에 사용중인 지역 입니다.4 : NO : " + timeSpace.errString);
                    return false;
                }
            }

            // 사용가능한 채널이 있는가?
            timeSpace.CheckChannel();
            if (multi.chno == 0)
            {
                MessageBox.Show("해당 시간대에 사용가능 채널이 없습니다.");
                return false;
            }

            return true;
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
                gweb.mainFrame.sendSigR(eSignalRMsgType.eScheduleDown);

            }
            catch (Exception ex)
            {
            }
        }

        private async void DeleteData()
        {
            SchduleRow r1 = await gweb.dBSqlite.SchduleGet(pName.Text);
            if (r1 == null) return;
            if (await gweb.dBSqlite.SchduleCDelete(r1.SchduleId))
            { 
                await gweb.dBSqlite.SchduleDelete(r1);
            }
        }
        #endregion

        private void check주간반복_CheckedChanged(object sender, EventArgs e)
        {
            if (check주간반복.Checked == true)
            {
                panel특정일자.Visible = false;
                panel주간.Visible = true;
            }
            else
            { 
                panel특정일자.Visible = true;
                panel주간.Visible = false;
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var t1 = this.dataGridView1.CurrentRow.DataBoundItem;
                var t2 = (SchduleRow)((System.Data.DataRowView)t1).Row;

                if (t2 == null)
                    return;

                SelSchduleId = t2.SchduleId;
                if (SelSchduleId == 0) return;
                if (SelSchduleId == oldSelSchduleId) return;
                oldSelSchduleId = SelSchduleId;

                dispDetail();
            }
            catch (Exception e1)
            {
                gweb.Log(e1.Message);
            }
        }

        private void masked시작시간_TextChanged(object sender, EventArgs e)
        {
            comp_Music1.GetDuration();
        }

        private void masked시작시간_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                masked종료시간.Focus();
            }
        }


        /*
        // 예약에서 수정은 지원하지 않음 - 예약 지역 중복 체크가 어려움 
        // 
        private async void SchduleUpdate()
        {
            gweb.dBSqlite.DBInit();
            if (comp_Music1.SelMusic.Count < 1 || comp_UGroup1.SelAssets().Count < 1)
            {
                AlertBox.Show("음원이나 지역이 선택 되어야 합니다.");
                return;
            }
            var t1 = dateTime일자.Text;
            SchduleRow r1 = await gweb.dBSqlite.SchduleGet(pName.Text);
            r1.GroupName = comp_UGroup1.GroupFilter;
            await gweb.dBSqlite.SchduleUpdate(r1);
            await gweb.dBSqlite.SchduleCDelete(r1.SchduleId);
            await gweb.dBSqlite.SchduleCSave(r1, comp_Music1.SelMusic, comp_UGroup1.SelAssets());
        }
        */


    }

}

using DataClass;
using simplepa2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static simplepa2.DataSet1;

namespace simplepa2
{

    public partial class SchduleMem
    {
        public int SchduleId { get; set; }
        public string Name { get; set; }
        public string EMNAME { get; set; }
        public string GroupName { get; set; }
        public string user_name { get; set; }
        public System.DateTime stime { get; set; }
        public System.DateTime etime { get; set; }
        public System.DateTime sdate { get; set; }
        public bool day1 { get; set; }
        public bool day2 { get; set; }
        public bool day3 { get; set; }
        public bool day4 { get; set; }
        public bool day5 { get; set; }
        public bool day6 { get; set; }
        public bool day7 { get; set; }
        public bool week { get; set; }
        public int chno { get; set; }
        public string duration { get; set; }
        public string tss { get; set; }
        public string tse { get; set; }

        public TimeSpan tss1 { get; set; }
        public TimeSpan tse1 { get; set; }
        public List<SchduleC> schduleC { get; set; } = new List<SchduleC>();
    }

    public class SchduleMemList
    {
        public List<SchduleMem> child { get; set; } = new List<SchduleMem>();
    }

    public class PlayList
    {
        public List<PlayItem> child { get; set; }
        public PlayList()
        {
            child = new List<PlayItem>();
        }
    }


    public class TimeSpace
    {
        public SchduleMem multi { get; set; } = new SchduleMem(); // 원 저장 데이터
        public List<SchduleMem> dbrlt { get; set; } = new List<SchduleMem>(); // 디비 검색 결과 
        public SchduleMemList _db { get; set; } = new SchduleMemList(); //디비 

        public int SchduleId { get; set; } = 0;
        int[] empty_chno { get; set; } = { 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1 };

        int srv_ch = 4; // 예약방송 서비스 채널 4,5,6,7 4개 // 8 mic 
        public string errString { get; set; } = "";

        public TimeSpace()
        {
        }

        public void makeDB()
        {
            gweb.dBSqlite.DBInit();

            // 디비투 이기종 테이블 리스트 복제 
            var s1 = Helper.DataTableToList<SchduleMem>(gweb.dBSqlite.Ds1.Schdule);
            var sc1 = Helper.DataTableToList<SchduleC>(gweb.dBSqlite.Ds1.SchduleC);

            foreach (var t1 in s1)
            {
                SchduleMem mem = new SchduleMem();
                mem = t1;
                TimeSpan st = new TimeSpan();
                TimeSpan.TryParseExact(mem.tss, @"hh\:mm", null, out st);
                TimeSpan et = new TimeSpan();
                TimeSpan.TryParseExact(mem.tse, @"hh\:mm", null, out et);
                mem.tss1 = st;
                mem.tse1 = et;
                mem.schduleC = sc1.Where(p=>p.SchduleId == t1.SchduleId).ToList();
                _db.child.Add(mem);
            }
        }

        internal void CheckChannel()
        {
            // 중복을 제외하고 빈 채널이 있는가?
            for (int i = srv_ch; i < 8; i++)
            {
                if (empty_chno[i] == 0)
                {
                    multi.chno = i;
                    break;
                }
            }
        }

        internal int GetID()
        {
            try
            {
                SchduleId = (int)_db.child.OrderBy(e1 => e1.SchduleId).Last().SchduleId + 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                SchduleId = 1;
            }

            return SchduleId;
        }

        internal bool CheckDay()
        {
            // 빈채널이 있는지 확인 
            foreach (SchduleMem m2 in dbrlt)
            {
                var t1 = m2.stime;
                errString = m2.SchduleId.ToString() + " : " + t1;
                return false;
            }
            return true;
        }


        internal bool CheckSpace()
        {
            int SchduleId = multi.SchduleId;
            List<SchduleMem> del = new List<SchduleMem>();

            // 초기화 시키고 
            for (int i = srv_ch; i < 8; i++)
            {
                empty_chno[i] = 0;
            }
            // 소스와 동일한 데이터이면 삭제 준비 
            foreach (var t1 in dbrlt)
            {
                if (t1.SchduleId == SchduleId)
                {
                    del.Add(t1);
                }
            }
            // 동일한 데이터 삭제 처리 
            foreach (var t1 in del)
            {
                dbrlt.Remove(t1);
            }

            // 빈채널이 있는지 확인 
            foreach (SchduleMem m2 in dbrlt)
            {
                empty_chno[m2.chno] = 1;
                foreach (var a1 in m2.schduleC)
                {
                    foreach (var a2 in multi.schduleC)
                    {
                        if (a1.AssetId == a2.AssetId)
                        {
                            errString = m2.SchduleId.ToString() + " : " + gweb.dBSqlite.AssetName(a1.AssetId);
                            return false;
                        }
                    }

                }
            }
            return true;
        }



        #region // 예약에서 디비 검색 
        // 예약에서 호출 
        // 반복 없는 시간 중복인 디비 점검 
        public void SchSearchDB()
        {
            List<SchduleMem> rlt1 = new List<SchduleMem>(); // 디비 검색 결과 
            rlt1 = SearchweekNo(_db);
            // 검색 데이터 취합 
            AddData(rlt1, dbrlt);
        }

        // 예약에서 호출 
        // 정규에 해당 요일 디비가 있는지 점검 
        public void SchSearchDBweek()
        {
            List<SchduleMem> rlt2 = new List<SchduleMem>(); // 디비 검색 결과 
            rlt2 = Searchweek(_db);

            // 주간반복에서 특정 요일에 데이터가 있는지 검사 
            List<SchduleMem> rlt3 = new List<SchduleMem>();
            switch (multi.stime.DayOfWeek)
            {
                case DayOfWeek.Monday: rlt3 = rlt2.Where(e1 => (e1.day1 == true)).ToList(); break;
                case DayOfWeek.Tuesday: rlt3 = rlt2.Where(e1 => (e1.day2 == true)).ToList(); break;
                case DayOfWeek.Wednesday: rlt3 = rlt2.Where(e1 => (e1.day3 == true)).ToList(); break;
                case DayOfWeek.Thursday: rlt3 = rlt2.Where(e1 => (e1.day4 == true)).ToList(); break;
                case DayOfWeek.Friday: rlt3 = rlt2.Where(e1 => (e1.day5 == true)).ToList(); break;
                case DayOfWeek.Saturday: rlt3 = rlt2.Where(e1 => (e1.day6 == true)).ToList(); break;
                case DayOfWeek.Sunday: rlt3 = rlt2.Where(e1 => (e1.day7 == true)).ToList(); break;
            }

            // 검색 데이터 취합 
            AddData(rlt3, dbrlt);
        }
        #endregion

        #region // 정규에서 디비 검색 

        // 정규에서 예약을 찾을경우 
        // 예약디비에서 중복인거 찾기 
        // 오늘 이후의 디비를 가져오고 거기서 시간중복을 찾는다. 
        // 시작시간 . 종료시간
        public List<SchduleMem> weekSearchweekNo(SchduleMemList db)
        {
            List<SchduleMem> r1 = new List<SchduleMem>(); // 디비 검색 결과 

            DateTime dt1 = DateTime.Now;

            // 금일이후의 데이터 가져오기  
            var t1 = db.child.Where(e1 => (e1.stime.Date >= dt1.Date) && e1.week == false).ToList(); //  시작 중복
            var t5 = t1.Where(e1 => (e1.tss1 <= multi.tss1 && e1.tse1 >= multi.tss1)); //  시작 중복
            var t6 = t1.Where(e1 => (e1.tss1 <= multi.tse1 && e1.tse1 >= multi.tse1)); //  종료 중복 
            var t7 = t1.Where(e1 => (e1.tss1 >= multi.tss1 && e1.tse1 <= multi.tse1)); //  확대
            var t8 = t1.Where(e1 => (e1.tss1 <= multi.tss1 && e1.tse1 >= multi.tse1)); //  포함 

            AddData(t5, r1);
            AddData(t6, r1);
            AddData(t7, r1);
            AddData(t8, r1);

            return r1;
        }


        // 정규에서 요일 변경시 
        // 예약에 해당요일 데이터가 있는지 점검 
        internal void SearchDBSch()
        {
            List<SchduleMem> rlt1 = new List<SchduleMem>(); // 디비 검색 결과 
            rlt1 = weekSearchweekNo(_db);

            List<SchduleMem> r2 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r3 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r4 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r5 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r6 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r7 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r8 = new List<SchduleMem>(); // 디비 검색 결과 

            // 모든 예약데이터에서 특정요일기준 데이터 검색 
            List<SchduleMem> r10 = new List<SchduleMem>(); // 디비 검색 결과 
            // 임의의 요일이 데이터 존재하는가? 
            if (multi.day1) r2 = rlt1.Where(e1 => e1.stime.DayOfWeek == DayOfWeek.Monday).ToList();
            if (multi.day2) r3 = rlt1.Where(e1 => e1.stime.DayOfWeek == DayOfWeek.Tuesday).ToList();
            if (multi.day3) r4 = rlt1.Where(e1 => e1.stime.DayOfWeek == DayOfWeek.Wednesday).ToList();
            if (multi.day4) r5 = rlt1.Where(e1 => e1.stime.DayOfWeek == DayOfWeek.Thursday).ToList();
            if (multi.day5) r6 = rlt1.Where(e1 => e1.stime.DayOfWeek == DayOfWeek.Friday).ToList();
            if (multi.day6) r7 = rlt1.Where(e1 => e1.stime.DayOfWeek == DayOfWeek.Saturday).ToList();
            if (multi.day7) r8 = rlt1.Where(e1 => e1.stime.DayOfWeek == DayOfWeek.Sunday).ToList();

            AddData(r2, r10);
            AddData(r3, r10);
            AddData(r4, r10);
            AddData(r5, r10);
            AddData(r6, r10);
            AddData(r7, r10);
            AddData(r8, r10);

            // 데이터 취합
            AddData(r10, dbrlt);
        }


        // 정규
        // 반복이 있는 시간 중복인 디비 점검 
        public void SearchDBweek()
        {
            List<SchduleMem> rlt2 = new List<SchduleMem>(); // 디비 검색 결과 
            rlt2 = Searchweek(_db);

            List<SchduleMem> r2 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r3 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r4 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r5 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r6 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r7 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r8 = new List<SchduleMem>(); // 디비 검색 결과 
            List<SchduleMem> r9 = new List<SchduleMem>(); // 디비 검색 결과 

            // 임의의 요일이 데이터 존재하는가? 
            if (multi.day1) r2 = rlt2.Where(e1 => e1.day1 == true).ToList();
            if (multi.day2) r3 = rlt2.Where(e1 => e1.day2 == true).ToList();
            if (multi.day3) r4 = rlt2.Where(e1 => e1.day3 == true).ToList();
            if (multi.day4) r5 = rlt2.Where(e1 => e1.day4 == true).ToList();
            if (multi.day5) r6 = rlt2.Where(e1 => e1.day5 == true).ToList();
            if (multi.day6) r7 = rlt2.Where(e1 => e1.day6 == true).ToList();
            if (multi.day7) r8 = rlt2.Where(e1 => e1.day7 == true).ToList();

            AddData(r2, r9);
            AddData(r3, r9);
            AddData(r4, r9);
            AddData(r5, r9);
            AddData(r6, r9);
            AddData(r7, r9);
            AddData(r8, r9);
            AddData(r9, r9);
            dbrlt = r9;

            // 데이터 취합
            AddData(r9, dbrlt);
        }
        #endregion

        // 예약에서 예약을 찾을 경우 
        // 예약디비에서 중복인거 찾기 
        // 시작시간 . 종료시간 , 방송일자 , 반복없음 키 
        public List<SchduleMem> SearchweekNo(SchduleMemList db)
        {
            List<SchduleMem> r1 = new List<SchduleMem>(); // 디비 검색 결과 
            // 임의의 시작과 종료가 디비에 존재 하는가 
            var t1 = db.child.Where(e1 => (e1.stime <= multi.stime && e1.etime >= multi.stime) && e1.week == false && e1.stime.Date == multi.stime.Date); //  시작 중복
            var t2 = db.child.Where(e1 => (e1.stime <= multi.etime && e1.etime >= multi.etime) && e1.week == false && e1.stime.Date == multi.stime.Date); //  종료 중복 
            var t3 = db.child.Where(e1 => (e1.stime >= multi.stime && e1.etime <= multi.etime) && e1.week == false && e1.stime.Date == multi.stime.Date); //  확대
            var t4 = db.child.Where(e1 => (e1.stime <= multi.stime && e1.etime >= multi.etime) && e1.week == false && e1.stime.Date == multi.stime.Date); //  포함 

            var t5 = db.child.Where(e1 => (e1.tss1 <= multi.tss1 && e1.tse1 >= multi.tss1) && e1.week == false && e1.stime.Date == multi.stime.Date); //  시작 중복
            var t6 = db.child.Where(e1 => (e1.tss1 <= multi.tse1 && e1.tse1 >= multi.tse1) && e1.week == false && e1.stime.Date == multi.stime.Date); //  종료 중복 
            var t7 = db.child.Where(e1 => (e1.tss1 >= multi.tss1 && e1.tse1 <= multi.tse1) && e1.week == false && e1.stime.Date == multi.stime.Date); //  확대
            var t8 = db.child.Where(e1 => (e1.tss1 <= multi.tss1 && e1.tse1 >= multi.tse1) && e1.week == false && e1.stime.Date == multi.stime.Date); //  포함 

            var t9 = t1.Where(e1 => (e1.tss1 <= multi.tss1 && e1.tse1 >= multi.tss1)); //  시작 중복
            var t10 = t1.Where(e1 => (e1.tss1 <= multi.tse1 && e1.tse1 >= multi.tse1)); //  종료 중복 
            var t11 = t1.Where(e1 => (e1.tss1 >= multi.tss1 && e1.tse1 <= multi.tse1)); //  확대
            var t12 = t1.Where(e1 => (e1.tss1 <= multi.tss1 && e1.tse1 >= multi.tse1)); //  포함 

            AddData(t1, r1);
            AddData(t2, r1);
            AddData(t3, r1);
            AddData(t4, r1);
            AddData(t5, r1);
            AddData(t6, r1);
            AddData(t7, r1);
            AddData(t8, r1);

            return r1;
        }

        public List<SchduleMem> Searchweek(SchduleMemList db)
        {
            List<SchduleMem> r2 = new List<SchduleMem>(); // 디비 검색 결과 
            // 임의의 시작과 종료가 디비에 존재 하는가 
            var t5 = db.child.Where(e1 => (e1.tss1 <= multi.tss1 && e1.tse1 >= multi.tss1) && e1.week == true); //  시작 중복
            var t6 = db.child.Where(e1 => (e1.tss1 <= multi.tse1 && e1.tse1 >= multi.tse1) && e1.week == true); //  종료 중복 
            var t7 = db.child.Where(e1 => (e1.tss1 >= multi.tss1 && e1.tse1 <= multi.tse1) && e1.week == true); //  확대
            var t8 = db.child.Where(e1 => (e1.tss1 <= multi.tss1 && e1.tse1 >= multi.tse1) && e1.week == true); //  포함 

            AddData(t5, r2);
            AddData(t6, r2);
            AddData(t7, r2);
            AddData(t8, r2);
            return r2;
        }

        private void AddData(IEnumerable<SchduleMem> t1, List<SchduleMem> r1)
        {
            foreach (SchduleMem m1 in t1)
            {
                var m11 = r1.Find(e => e.SchduleId == m1.SchduleId);
                if (m11 == null)
                    r1.Add(m1);
            }
        }



        #region // 사용안함 , 멀티에서 디비 검색 
        // 멀티에서 호출 
        // 반복 없는 시간 중복인 디비 점검 
        public void SearchDBweekNo()
        {
            List<SchduleMem> rlt1 = new List<SchduleMem>(); // 디비 검색 결과 
            rlt1 = SearchweekNo(_db);
            // 검색 데이터 취합 
            AddData(rlt1, dbrlt);
        }
        #endregion
    }
}

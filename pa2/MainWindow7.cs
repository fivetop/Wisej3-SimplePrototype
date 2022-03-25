using DataClass;
using gClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Threading;
using Wisej.CodeProject;
using Wisej.CodeProject.DataSet1TableAdapters;
using static Wisej.CodeProject.DataSet1;

namespace pa
{
    //
    // 스피커 온라인 감시 처리 
    //
    public partial class MainWindow : Window
    {
        #region // 스피커 온라인 감시 처리 

        // 상태가 변경되었을 경우만 디스플레이
        private void SpeakerCheck(string str2, int v)
        {
            var t4 = ds1.Assets.Where(p => p.ip == str2);
            if (t4.Count() == 0)
                return;

            var t3 = ds1.Assets.First(p => p.ip == str2);
            if (t3 == null)
                return;

            if (v == 1)
            {
                if (t3.state == "On-Line") return;
                t3.state = "On-Line";
                g.Log("On-Line :" + str2);
            }
            else
            {
                if (t3.state == "") return;
                t3.state = "";
                t3.state_old = "";
                g.Log("Off-Line:" + str2);
            }

            dBSqlite.EventvmIP(t3);
            //updateAlarmEvent();
            //if (MainTabControl.SelectedIndex == 5)
            //    _T6.dispFloorMap();
        }

        bool check1 = false; // 재 실행 방지 
        bool check2 = false; // 재 실행 방지 

        private void SpeakerChecker_OnSpeakerCheck(object sender, EventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                if (check1 || check2) return;
                check1 = true;

                try
                {
                    LScap.g.capData.Clear();
                    LSmDNSW.Resolver.intfindx = gl.NetworkCardmDNS;
                    LSmDNSW.g.GetCard();
                    LSmDNSW.g.GetMain();
                }
                catch (Exception e1)
                {
                    //Console.WriteLine(e1.Message);
                }
                check1 = false;
            }));
        }

        private void SpeakerChecker_OnAliveChk(object sender, EventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                if (check2) return;
                check2 = true;
                var t2 = LScap.g.capData;

                try
                {
                    g.Log("Device Check : " + t2.Count.ToString());
                    foreach (var t1 in ds1.Assets)
                    {
                        if (t1.state != t1.state_old)
                            t1.state_old = t1.state;
                        t1.state = ""; // "Off-Line";
                    }

                    foreach (var t3 in ds1.Assets)
                    {
                        var t4 = t2.Contains(t3.ip);
                        if (t4)
                        {
                            //g.Log("Alive IP.. : " + t3.ip);
                            t3.state = "On-Line";
                            // 올드가 오프라인이면 
                            if (t3.state_old == "")
                            {
                                SpeakerCheck(t3.ip, 1);
                            }
                        }
                        else
                        {
                            // 온라인이었다가 오프라인이면 
                            if (t3.state != t3.state_old)
                            {
                                SpeakerCheck(t3.ip, 0);
                            }
                        }
                    }

                    if (t2.Count < 2)
                    {
                        speakerChecker.T2chktimer.Start();
                        //LSCap.Refresh();
                    }

                }
                catch (Exception e1)
                {
                    //Console.WriteLine(e1.Message);

                }
                check2 = false;
            }));
        }
        #endregion

    }
}

using System.Windows;
using pa.Windows;
using pa.classes;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System;
using System.Timers;
using System.Windows.Threading;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Interop;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.IO;
using System.Text;
using System.Collections.Generic;
using gClass;
using System.ComponentModel;
using System.Diagnostics;
using Wisej.CodeProject;
using static Wisej.CodeProject.DataSet1;

namespace pa
{
    // 다원 방송 처리 및 윈도우 메시지 처리 
    public partial class MainWindow : Window
    {
        // Speaker Checker 
        uint RegisterMessage;
        // UserMessage 
        uint RegisterMessage2;
        long old_wParam { get; set; }
        long old_lParam { get; set; }

        List<ExtProcess> BSpro = new List<ExtProcess>();

        private void InitMultiBS()
        {
            if (processCheck())
                return;
            for (int i = 1; i < 9; i++)
            {
                //string fstr = "LSNAudio" + i.ToString() + ".exe";
                //File.Copy("LSNAudio.exe", fstr, true);
                ExtProcess ep1 = new ExtProcess(0, i);
                BSpro.Add(ep1);
            }
        }


        private bool processCheck()
        {
            try
            {
                Process[] processlist = Process.GetProcesses();

                foreach (Process theprocess in processlist)
                {
                    if (theprocess.ProcessName.Contains("LSNAudio"))
                    {
                        return true;
                        //theprocess.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(this, "Error" + ex.Message, "Error");
            }
            return false;
        }

        #region // 다원방송 처리 로직  2 ~ 8
        private void dispMBSRun(int p1)
        {
            int po1 = p1;
            //Console.WriteLine("dispMBSRun : " + po1.ToString()); 
            if (po1 < 2 || po1 > 8) return;
            var t1 = g.play8ch[po1];
            if (t1.state == "방송중") return;
            t1.state = "방송중";
            //_T3.SchBS(t1.idno);
            g.SendR("PLAYING", eSignalRMsgType.ePlaying, po1, 0);
        }

        // **방송종료처리 - 다원 방송 종료
        public void dispMBSStop(int p1)
        {
            int po1 = p1;
            if (po1 < 2 || po1 > 8) return;
            if (po1 == 8) 
            {}
            var t1 = g.play8ch[po1];
            if (t1 == null) return;
            if (t1.state != "방송중") return;
            t1.state = "종료";
            //_T3.SchBS(t1.idno);
            StopMBS(t1.idno, po1);
            t1.p_run = false;
            g.Log("다원방송 종료 처리.." +t1.chno.ToString() + " : "+ t1.idno.ToString());

            dBSqlite.Delete(t1.idno);
            dBSqlite.Eventvm("다원방송 종료", t1.chno.ToString() + "번 채널", t1.idno.ToString());
            g.SendR("PLAYEND", eSignalRMsgType.ePlayEnd , 0, 0);
        }

        // 현재 방송 중지 처리 
        internal void StopMBS(int idno, int chno)
        {
            SetDSPSpeakerOFF(idno);
            g.play8ch[chno] = new PlayItemSig();

            GlobalMessage.Send(RegisterMessage2, chno, 1); // 중지처리 

            /*
            ExtProcess del = null;
            foreach (ExtProcess p1 in BSpro)
            {
                if (p1.id == idno)
                {
                    del = p1;
                    break;
                }
            }
            if (del == null) return;
            del.Kill();
            BSpro.Remove(del);
            */
        }

        // 다원방송 종료 처리시 
        internal void StopMBSEM()
        {
            //g.play8ch[po1] = new PlayItem();
            foreach (var t2 in g.play8ch)
            {
                t2.p_run = false;
                if (t2.state == "방송중")
                {
                    t2.state = "취소";
                    t2.p_run = false;
                    //_T3.SchBS(t2.idno);
                    if(t2.chno > 1)
                    {
                        g.DSP_metrix_initial(t2.chno);
                        GlobalMessage.Send(RegisterMessage2, t2.chno, 1); // 중지처리 
                    }
                }
            }
/*
            ExtProcess del = null;
            foreach (ExtProcess p1 in BSpro)
            {
                p1.Kill();
            }
            BSpro.Clear();
*/
        }


        static bool lockF = false;
        private void MultiBS()
        {
            if (lockF) return;
            lockF = true;
            foreach (PlayItemSig pl1 in g.play8ch)
            {
                if (pl1.p_run)
                    continue;
                if (pl1.chno == 0 || pl1.idno == 0)
                    continue;
                if (pl1.state != "대기")
                    continue;
                pl1.p_run = true;
                playMBS(pl1);
            }
            Thread.Sleep(500);
            PlayChildProcess();
            Console.WriteLine("다원방송 시작 : ");

            lockF = false;
        }

        public void playMBS(PlayItemSig sch_play)
        {
            // 1번채널 방송중인지 체크 
            if (CheckPlayItem(sch_play) == false)
            {
                g.Log(sch_play.idno.ToString() + "번의 방송은 동일지역 방송으로 취소됩니다.");
                return;
            }
            if (g.em_status == 1 || g.em_status == 3 || g.em_status == 5)
            {
                sch_play.state = "취소";
                //_T3.SchBS(sch_play.idno);
                g.Log(sch_play.idno.ToString() + "번의 방송은 비상방송으로 취소됩니다.");
                return;
            }

            // 다원방송 채널 할당 처리 
            if (SetDSPSpeakerON(sch_play.idno) == false)
            {
                sch_play.state = "취소";
                //_T3.SchBS(sch_play.idno);
                g.Log(sch_play.idno.ToString() + "번의 방송은 해당 지역에 스피커가 존재하지 않으므로 취소 됩니다.");
                return;
            }
            PlayChildProcess(sch_play.chno, sch_play.idno);
            /*
            ExtProcess ep1 = new ExtProcess(sch_play.idno, sch_play.chno);
            BSpro.Add(ep1);
            */
        }

        // 1번 채널이 방송중인 상테에서 다원방송이 들어온 경우 사용자에게 알림처리 
        private bool CheckPlayItem(PlayItemSig sch_play)
        {
            bool rlt = true;

            if (g.curr_play.state == "방송중")
            {
                if (g.CheckSpace(g.curr_play, sch_play) == true)
                {
                    // 클라이언트로 알리기 처리 
                    //Timerevent.item1 = g.curr_play;
                    //Timerevent.item2 = sch_play;
                    //updateEvent();
                    return false;
                }
            }
            return rlt;
        }

        private bool SetDSPSpeakerON(int idno)
        {
            bool rlt = false;
            SimpleMulti cur_play = null;
            List<AssetBase> play = new List<AssetBase>();

            var t11 = gl._SimpleMultiList.child.Find(p => p.idno == idno);
            var t21 = gl._SimpleMultiListSch.child.Find(p => p.idno == idno);
            if (t11 != null) cur_play = t11;
            if (t21 != null) cur_play = t21;

            foreach (AssetBase t1 in cur_play.gstree.child)
            {
                if (t1.ip == "")
                {
                    g.Log("Speaker IP.. " + t1.path + " : " + t1.DeviceName);
                    continue;
                }
                var sst2 = gl._SpeakerList.asset.First(p => p.DeviceName == t1.DeviceName && p.ch == t1.ch);
                if (sst2.state == "")
                {
                    //g.Log("Speaker Off.. " + t1.path + " : " + t1.DeviceName);
                    //continue;
                }
                
                var sst = gl.danteDevice._DanteDevice.Where(p => p.DeviceName == t1.DeviceName && p.chspk == t1.ch);
                if (sst.Count() < 1)
                {
                    g.Log("DaneDevice.. " + t1.path + " : " + t1.DeviceName);
                    continue;
                }
                var sst1 = sst.First(p => p.DeviceName == t1.DeviceName);
                if (sst1 == null) continue;
                if (sst1.ip == "" || sst1.ip_dspctrl == "") continue;
                Console.WriteLine("DSP Metrix Out ==> In :" + sst1.ip_dspctrl + " : " + t1.path + " : " + t1.id);
                play.Add(t1);
                // 스피커가 하나라도 있으면 처리 
                rlt = true;
            }

            if (play.Count > 0)
            {
                g.DSP_MakeGroupSpeaker(play, 1, BS_DSP_STATE.MUL_BS, cur_play.chno - 1);
            }
            return rlt;
        }

        private bool SetDSPSpeakerOFF(int idno)
        {
            bool rlt = false;
            SimpleMulti cur_play = null;
            List<AssetBase> play = new List<AssetBase>();

            var t11 = gl._SimpleMultiList.child.Find(p => p.idno == idno);
            var t21 = gl._SimpleMultiListSch.child.Find(p => p.idno == idno);
            if (t11 != null) cur_play = t11;
            if (t21 != null) cur_play = t21;

            if (cur_play == null)
                return rlt;
            foreach (AssetBase t1 in cur_play.gstree.child)
            {
                if (t1.ip == "") continue;

                var sst = gl.danteDevice._DanteDevice.Where(p => p.DeviceName == t1.DeviceName && p.chspk == t1.ch);
                if (sst.Count() < 1) continue;
                var sst1 = sst.First(p => p.DeviceName == t1.DeviceName);
                if (sst1 == null) continue;
                if (sst1.ip == "" || sst1.ip_dspctrl == "") continue;
                play.Add(t1);
                // 스피커가 하나라도 있으면 처리 
                rlt = true;
            }

            if (play.Count > 0)
            {
                g.DSP_MakeGroupSpeaker(play, 0, BS_DSP_STATE.MUL_BS, cur_play.chno - 1);
            }
            return rlt;
        }


        #endregion

        #region // IPC 처리 

        public void IPC()
        {
            RegisterMessage = GlobalMessage.Register("SpeakerCheck");
            RegisterMessage2 = GlobalMessage.Register("MultiSound");
            ComponentDispatcher.ThreadFilterMessage += ComponentDispatcher_ThreadFilterMessage;
        }
        private void PlayChildProcess()
        {
            //GlobalMessage.Send(RegisterMessage2, 99, 2000);
        }
        private void PlayChildProcess(int chno, int id)
        {
            GlobalMessage.Send(RegisterMessage2, chno, id);
        }


        private void ComponentDispatcher_ThreadFilterMessage(ref MSG msg, ref bool handled)
        {
            if (!((RegisterMessage == msg.message) || (RegisterMessage2 == msg.message)))
                return;
            long s1 = msg.wParam.ToInt64();
            long s2 = msg.lParam.ToInt64();

            string str1 = msg.wParam.ToString() + " : " + msg.lParam.ToString();
            //_out.Inlines.Add(str1);
            //if (old_lParam == s2 && s1 == old_wParam)
            //    return;
            old_wParam = s1;
            old_lParam = s2;

            switch (s1)
            {
                case 200: // Off -> On
                    Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate
                    {
                        string str2 = gl.long2IPstring(s2);
                        SpeakerCheck(str2, 1);
                    }));
                    break;
                case 300: // On -> Off
                    Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate
                    {
                        string str3 = gl.long2IPstring(s2);
                        SpeakerCheck(str3, 0);
                    }));
                    break;
            }


            // wparam 99 lparam 1000 ~ 5000
            // rcv play message  chno, 2000

            if (RegisterMessage2 != msg.message)
                return;

            int p1 = msg.wParam.ToInt32();

            //Console.WriteLine(str1);
            switch (s2)
            {
                case 1000:
                    Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate
                    {
                        dispMBSRun(p1);
                    }));

                    break;
                case 2000:
                    break;
                case 5000:
                    //음원 종료 S->M 
                    //Console.WriteLine(msg.wParam.ToString() + " " + msg.lParam.ToString());
                    Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate
                    {
                        dispMBSStop(p1);
                    }));
                    break;
            }

        }

        #endregion

    }
}

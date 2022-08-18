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
using simplepa2;
using static simplepa2.DataSet1;
using DataClass;

namespace pa
{
    //
    // 다원 방송 처리 및 윈도우 메시지 처리 
    //
    public partial class MainWindow : Window
    {
        // UserMessage 
        uint MultiSoundReg { get; set; }
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
        private void MBSRun(int p1)
        {
            int chno = p1;
            //Console.WriteLine("dispMBSRun : " + po1.ToString()); 
            if (chno < 2 || chno > 8) return;
            var t1 = g.playItems[chno];
            if (t1.state == "방송중") return;
            t1.state = "방송중";
            //_T3.SchBS(t1.idno);
            g.SendSigR("PLAYING", eSignalRMsgType.ePlaying, chno, 0);
        }

        // **방송종료처리 - 다원 방송 종료
        public void MBSStop(int p1)
        {
            int chno = p1;
            if (chno < 2 || chno > 8) return;
            {}
            var t1 = g.playItems[chno];
            if (t1 == null) return;
            if (t1.state != "방송중") return;
            t1.state = "종료";
            //_T3.SchBS(t1.idno);
            // 현재 방송 중지 처리 
            g.DSP_MakeGroupSpeaker(t1.Play, 0, BS_DSP_STATE.MUL_BS, t1.chno);
            GlobalMessage.Send(MultiSoundReg, chno, 1); // 중지처리 
            t1.p_run = false;

            string l1 = "다원방송종료";

            g.Log(l1 +t1.chno.ToString() + " : "+ t1.idno.ToString());
            dBSqlite.Delete(t1.idno);
            dBSqlite.Eventvm(l1, t1.chno.ToString() + "번 채널", t1.idno.ToString());
            g.SendSigR("PLAYEND", eSignalRMsgType.ePlayEnd , 0, 0);
            g.playItems[chno] = new PlayItem();
        }


        // 다원방송 종료 처리시 
        internal void StopMBSEM()
        {
            //g.play8ch[po1] = new PlayItem();
            foreach (var t2 in g.playItems)
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
                        GlobalMessage.Send(MultiSoundReg, t2.chno, 1); // 중지처리 
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
            foreach (PlayItem pl1 in g.playItems)
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

        public void playMBS(PlayItem sch_play)
        {
            // 1번채널 방송중인지 체크 
            //
            if (em_status == 1 || em_status == 3 || em_status == 5)
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

        private bool SetDSPSpeakerON(int idno)
        {
            bool rlt = true;
            return rlt;
        }

        #endregion

        #region // IPC 처리 

        public void IPC()
        {
            MultiSoundReg = GlobalMessage.Register("MultiSound");
            ComponentDispatcher.ThreadFilterMessage += ComponentDispatcher_ThreadFilterMessage;
        }
        private void PlayChildProcess()
        {
            //GlobalMessage.Send(RegisterMessage2, 99, 2000);
        }
        private void PlayChildProcess(int chno, int id)
        {
            GlobalMessage.Send(MultiSoundReg, chno, id);
        }


        private void ComponentDispatcher_ThreadFilterMessage(ref MSG msg, ref bool handled)
        {
            if (!(MultiSoundReg == msg.message))
                return;
            long s1 = msg.wParam.ToInt64();
            long s2 = msg.lParam.ToInt64();

            string str1 = msg.wParam.ToString() + " : " + msg.lParam.ToString();
            //_out.Inlines.Add(str1);
            //if (old_lParam == s2 && s1 == old_wParam)
            //    return;
            old_wParam = s1;
            old_lParam = s2;

            // wparam 99 lparam 1000 ~ 5000
            // rcv play message  chno, 2000

            if (MultiSoundReg != msg.message)
                return;

            int p1 = msg.wParam.ToInt32();

            //Console.WriteLine(str1);
            switch (s2)
            {
                case 1000:
                    Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate
                    {
                        MBSRun(p1);
                    }));

                    break;
                case 2000:
                    break;
                case 5000:
                    //음원 종료 S->M 
                    //Console.WriteLine(msg.wParam.ToString() + " " + msg.lParam.ToString());
                    Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate
                    {
                        MBSStop(p1);
                    }));
                    break;
            }
        }
        #endregion

    }
}

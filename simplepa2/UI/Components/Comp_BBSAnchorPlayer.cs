using simplepa2.UI.Popups;
using System;
using System.Collections.Generic;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Components
{
    public partial class Comp_BBSAnchorPlayer : Wisej.Web.UserControl
    {
        private Form_FilePlayerMusicSelector form_fileSelector;

        public event CompBBSAnchorPlayerPlayEventHandler PlayerStarter;
        public delegate void CompBBSAnchorPlayerPlayEventHandler(object sender, CompBBSAnchorPlayerPlayEventArgs e);

        public event CompBBSAnchorPlayerStopEventHandler PlayerStop;
        public delegate void CompBBSAnchorPlayerStopEventHandler(object sender, CompBBSAnchorPlayerStopEventArgs e);

        public int MUSIC_FIRST_FILE = 0;

        public Timer timer = new Timer();
        public Timer sleeptimer = new Timer();
        public Timer playTimer = new Timer();

        public string selectFile = "";

        public int iCurrentPlayIndex = 0;
        public bool bMusicPlay = false;
        public int iPlaySec = 0;
        public int iPlayMaxSec = 0;

        
        public List<MusicsRow> SelMusic { get; set; } = new List<MusicsRow>();

        public Comp_BBSAnchorPlayer()
        {
            InitializeComponent();

            timer.Interval = 1500;
            timer.Tick += new EventHandler(timer_Tick);

            playTimer.Interval = 1000;
            playTimer.Tick += new EventHandler(playTimer_Tick);

            sleeptimer.Tick += new EventHandler(sleepTimer_Tick);


        }

        private void bt_addFileList_Click(object sender, EventArgs e)
        {
            openFileListSelector();
        }
        private void form_fileSelector_Closed(object sender, EventArgs e)
        {
            gweb.mainFrame.reDraw();
        }

        private void form_fileSelector_Confirmed(object sender, FilePlayerCloseEventArgs e)
        {            
            if(bMusicPlay)  // 음악 플레이중 파일 리스트를 재 작성 했다면
            {
                bt_filePlay_Click(this, null);   // 버튼을 시스템이 눌러 정지 시킴 서버+웹  

            }
            this.dg_playList.DataSource = null;
            this.dg_playList.DataSource = e.SelMusic;
            this.SelMusic = e.SelMusic;

            setupFirstFileForPlay(MUSIC_FIRST_FILE);            
        }

        private void dg_playList_DoubleClick(object sender, EventArgs e)
        {
            openFileListSelector();
        }

        public void openFileListSelector()
        {
            this.form_fileSelector = null;

            if(SelMusic.Count == 0)
            {
                this.form_fileSelector = new Form_FilePlayerMusicSelector();

            }
            else
            {
                this.form_fileSelector = new Form_FilePlayerMusicSelector(this.SelMusic);
            }

            this.form_fileSelector.Closed += new System.EventHandler(this.form_fileSelector_Closed);
            this.form_fileSelector.closeSelector += new Form_FilePlayerMusicSelector.FilePlayerCloseEventHandler(this.form_fileSelector_Confirmed);
            //this.form_BBCZoneImport.Disposed += new Form
            this.form_fileSelector.ShowDialog();

        }

        public void setupFirstFileForPlay(int iCurrentPlayIndex)
        {
            if(SelMusic.Count == 0)
            {
                return; 
            }

            // 파일 셋업 
            MusicsRow mrTemp = this.SelMusic[iCurrentPlayIndex] as MusicsRow;
            this.lb_playFileName.Text = mrTemp.FileName;
            this.lb_FileContent.Text = mrTemp.FileContent;
            this.lb_playMax.Text = mrTemp.duration;
            this.iPlayMaxSec = ConvertStringTimeToSecInt(mrTemp.duration);


            this.lb_playCal.Text = "00:00:00";

            // 음악이 바로 셋업안되서 타이머로 처리 
            this.audioDefault.SourceURL = "";
            this.selectFile = "Media/" + mrTemp.FileName;

            
            // 플레이시간 초기화 
            this.iPlaySec = 0; // 플레이시간 0
            this.iCurrentPlayIndex = 0; // 플레이 인덱스

            playTimer.Stop(); // 보호 코드 
            bMusicPlay = false;  // 곡플레이도 초기화

            this.bt_filePlay.Enabled = false;
            timer.Start();         
        }


        public void audioPlayerStart()   // View 메인에서 직접 컨트롤
        {
            bMusicPlay = true;            

     
            if (SelMusic.Count > 0)
            {
                this.iPlaySec = 0; // 플레이시간 0 부터시작
                this.bMusicPlay = true; // 음악 플레이 진입

                this.bt_filePlay.BackgroundImageSource = "Images/music-crrl-4.png";  // 스타트 이므로 스탑 모양으로 변경

                playTimer.Start();

                this.audioDefault.Play();                

                holdPlayButton(200);   // 더블클릭방지 및 서버시작시간 맞추기용 milli second


                // Main에서 컨트롤
            }
            else
            {
                MessageBox.Show("LAWTEXT : 선택된 곡이 없습니다.!, 곡을 선택하세요");
                return;
            }            
        }

        public void audioPlayerStop()   // View 메인에서 직접 컨트롤
        {
            bMusicPlay = false;
            this.bt_filePlay.BackgroundImageSource = "Images/music-crrl-3.png"; // 스탑 이므로 스타트 모양으로 변경

            playTimer.Stop();
            this.audioDefault.Pause();

            holdPlayButton(1000);   // 더블클릭방지 및 서버시작시간 맞추기용 milli second
                                    // Main에서 컨트롤

        }

        public void audioPlayerNext()
        {
            iCurrentPlayIndex++;

            if (SelMusic.Count <= iCurrentPlayIndex)  // 다음번호가 인덱스와 숫자가 같은경우 마지막 임  카운트1부터 인덱스는 0부터
            {
                AlertBox.Show("Play 리스트 마지막 입니다. ");
                PlayerStop(this, new CompBBSAnchorPlayerStopEventArgs(this.SelMusic));  // vIEW로 종료 되었음을 알려주고
                setupFirstFileForPlay(MUSIC_FIRST_FILE);   // 음원 셋업 초기화 
            }
            else   // 
            {
                // 다음 파일 셋업 
                MusicsRow mrTemp = this.SelMusic[iCurrentPlayIndex] as MusicsRow;
                this.lb_playFileName.Text = mrTemp.FileName;
                this.lb_FileContent.Text = mrTemp.FileContent;
                this.lb_playMax.Text = mrTemp.duration;
                this.iPlayMaxSec = ConvertStringTimeToSecInt(mrTemp.duration);
                this.lb_playCal.Text = "00:00:00";     
                this.audioDefault.SourceURL = "Media/" + mrTemp.FileName;       // 파일이 변경되는 경우 다이렉트 셋업 
                
                audioPlayerStart();  // 플레이 시작
            }
        }

        private void bt_filePlay_Click(object sender, EventArgs e)
        {
            if (bMusicPlay) // 플레이 상태 > 끄기
            {
                PlayerStop(this, new CompBBSAnchorPlayerStopEventArgs(this.SelMusic));
                // 메인으로 스탑하라고 신호 보내고 메인에서 객체로 컨트롤                
            }
            else  // 중단 상태 > 시작 
            {
                PlayerStarter(this, new CompBBSAnchorPlayerPlayEventArgs(this.SelMusic));
                // View로 버튼눌렀음을 알려줌
            }
        }

        private void audioDefault_Ended(object sender, EventArgs e)
        {
            AlertBox.Show("곡이 끝났습니다.");
            audioPlayerStop();
            audioPlayerNext();

        }
        private void bt_playNext_Click(object sender, EventArgs e)
        {
            audioPlayerNext();
            // Event 날려줌 
        }

        #region // Timer 처리 관리

        public void timer_Tick(object sender, EventArgs e)  // Audio Source 안정성 용 Timer
        {
            this.audioDefault.SourceURL = selectFile;
            this.bt_filePlay.Enabled = true;
            timer.Stop();
        }

        public void playTimer_Tick(object sender, EventArgs e)  // 플레이시간 재는 이벤트
        {
            if (bMusicPlay)
            {
                iPlaySec++;
                lb_playCal.Text = ConvertToTimeString(iPlaySec);

                if(iPlaySec > iPlayMaxSec)   // 시간이 다 되었는데 종료가 안된다면 자동으로 다음곡
                {
                    audioPlayerStop();
                    audioPlayerNext();
                }               
            }
            else
            {
                playTimer.Stop();
            }
        }

        public static string ConvertToTimeString(int iSecInteger)
        {
            // 초를 60으로 나눈 몫이 분, 나머지가 초
            int seconds = iSecInteger % 60;
            int minutes = (iSecInteger / 60) % 60;
            int hours = iSecInteger / 3600;

            // 시, 분, 초를 2자리수로 맞추기 위해 ToString() 메소드에 "00" 형식 지정자 사용
            return $"{hours:00}:{minutes:00}:{seconds:00}";
        }

        
        public static int ConvertStringTimeToSecInt(string timeString)
        {      
            string[] timeParts = timeString.Split(':');
            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);
            int seconds = int.Parse(timeParts[2]);
            return (hours * 3600) + (minutes * 60) + seconds;
        }    

        public void sleepTimer_Tick(object sender, EventArgs e)  // Button 중복 방지용 이벤트처리
        {
            this.bt_filePlay.Enabled = true;
            sleeptimer.Stop();
        }

        public void holdPlayButton(int holdMiliiSecond) 
        {
            this.bt_filePlay.Enabled = false;
            sleeptimer.Interval = holdMiliiSecond;
            sleeptimer.Start();
        }

        internal void SetMusic(List<MusicsRow> musicsRows)
        {
            SelMusic = musicsRows;
            this.dg_playList.DataSource = null;
            this.dg_playList.DataSource = SelMusic;
            setupFirstFileForPlay(MUSIC_FIRST_FILE);
        }


        #endregion




        #region // Event ARGS 선언
        public class CompBBSAnchorPlayerPlayEventArgs : EventArgs
        {
            internal CompBBSAnchorPlayerPlayEventArgs(List<MusicsRow> SelMusic)
            {
                this.SelMusic = SelMusic;
            }

            public List<MusicsRow> SelMusic
            {
                get;
                private set;
            }
        }

        public class CompBBSAnchorPlayerStopEventArgs : EventArgs
        {
            internal CompBBSAnchorPlayerStopEventArgs(List<MusicsRow> SelMusic)
            {
                this.SelMusic = SelMusic;
            }

            public List<MusicsRow> SelMusic
            {
                get;
                private set;
            }
        }
        #endregion


    }
}

using System;
using System.Collections.Generic;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Popups
{
    public partial class Form_FilePlayerMusicSelector : Wisej.Web.Form
    {

        public List<MusicsRow> SelMusic { get; set; } = new List<MusicsRow>();

        public event FilePlayerCloseEventHandler closeSelector;
        public delegate void FilePlayerCloseEventHandler(object sender, FilePlayerCloseEventArgs e);

        public Form_FilePlayerMusicSelector()
        {
            InitializeComponent();
        }

        public Form_FilePlayerMusicSelector(List<MusicsRow> SelMusic)
        {
            InitializeComponent();

            this.SelMusic = SelMusic; 
            this.dg_selectedMusicList.DataSource = SelMusic;
        }

        private void Form_FilePlayerMusicSelector_Load(object sender, EventArgs e)
        {
            reDraw();
        }

        public void reDraw()
        {
            try
            {
                this.musicsTableAdapter.Fill(dataSet1.Musics);
                this.dg_selectedMusicList.DataSource = SelMusic;
            }
            catch (Exception e)
            {
                MessageBox.Show("LAW TEXT : Music 데이터를 가져오는 중 예외발생 " + e.Message);
            }
                      
        }

        private void bt_closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_enterList_Click(object sender, EventArgs e)
        {
            closeSelector(this, new FilePlayerCloseEventArgs(this.SelMusic));
            this.Close();
        }    



        private void bt_deSelect_Click(object sender, EventArgs e)
        {

            dg_selectedMusicList_CellMouseDoubleClick(this.dg_selectedMusicList, null);

        }

        private void dg_musicList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var t1 = this.dg_musicList.CurrentRow.DataBoundItem;            

            MusicsRow getRow = (MusicsRow)((System.Data.DataRowView)t1).Row;

            addSelectedMusicItems(getRow);
            
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            dg_musicList_CellMouseDoubleClick(this.dg_musicList, null);
        }

        private void dg_selectedMusicList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var t1 = this.dg_selectedMusicList.CurrentRow.DataBoundItem;            

            // MusicsRow getRow = (MusicsRow)((System.Data.DataRowView)t1).Row;
            
            delSelectedMusicItems(t1 as MusicsRow);                        
        }

        private void addSelectedMusicItems(MusicsRow getRow)
        {
            /*
            if(SelMusic.Count == 0)  // 빈 경우는 바로 추가
                this.SelMusic.Add(getRow);
            else
            {
                MusicsRow mRow = SelMusic.Find(x => x.MusicId == getRow.MusicId);

                if (mRow != null)
                {
                    // AlertBox.Show("LAWTEXT : 중복된 데이터가 있습니다. ID : " + mRow.MusicId + " 을 제외합니다.");
                    return;
                }
                this.SelMusic.Add(getRow);
            } */

            this.SelMusic.Add(getRow);

            this.dg_selectedMusicList.DataSource = null;
            this.dg_selectedMusicList.DataSource = this.SelMusic;
            this.dg_selectedMusicList.Refresh();
        }

        private void delSelectedMusicItems(MusicsRow getRow)
        {           
            MusicsRow mRow = SelMusic.Find(x => x.MusicId == getRow.MusicId);
            this.SelMusic.Remove(getRow);

            this.dg_selectedMusicList.DataSource = null;
            this.dg_selectedMusicList.DataSource = this.SelMusic;
            this.dg_selectedMusicList.Refresh();
        }

    }

    public class FilePlayerCloseEventArgs : EventArgs
    {
        internal FilePlayerCloseEventArgs(List<MusicsRow> SelMusic)
        {
            this.SelMusic = SelMusic;
        }

        public List<MusicsRow> SelMusic
        {
            get;
            private set;
        }
    }
}

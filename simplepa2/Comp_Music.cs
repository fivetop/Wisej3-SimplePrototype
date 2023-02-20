using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2
{
    public partial class Comp_Music : Wisej.Web.UserControl
    {

        public event EventHandler eventMusicDuration;

        public List<MusicsRow> SelMusic { get; set; } = new List<MusicsRow>();

        public Comp_Music()
        {
            InitializeComponent();
        }

        private void Comp_Music_Load(object sender, EventArgs e)
        {
        }

        public void reDraw()
        { 
            this.dataGridView1.DataSource = gweb.dBSqlite.Ds1.Musics.ToList();

            if (SelMusic.Count() > 0)
            {
                this.dataGridView2.DataSource = null;
                this.dataGridView2.DataSource = SelMusic;
                dataGridView2.Refresh();
                GetDuration();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1_CellMouseDoubleClick(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2_CellMouseDoubleClick(null, null);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var t1 = this.dataGridView1.CurrentRow.DataBoundItem;
            SelMusic.Add((MusicsRow)t1);
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = SelMusic;
            dataGridView2.Refresh();
            GetDuration();
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (SelMusic.Count == 0)
                return;
            try
            {
                var t1 = this.dataGridView2.CurrentRow.DataBoundItem;
                SelMusic.Remove((MusicsRow)t1);
                //this.dataGridView2.DataSource = null;
                //this.dataGridView2.DataSource = bind;
                dataGridView2.Refresh();
                GetDuration();
            }
            catch (Exception e1)
            {
            }
        }

        public string duration = "";
        public string GetDuration()
        {
            duration = "00:00";
            TimeSpan ts1 = new TimeSpan();

            foreach (var t1 in SelMusic)
            {
                TimeSpan st = new TimeSpan();
                TimeSpan.TryParseExact(t1.duration, @"hh\:mm\:ss", null, out st);
                ts1 = ts1 + st;
            }
            ts1 = ts1 + new TimeSpan(0, 0, 59);
            duration = ts1.ToString(@"hh\:mm");

            eventMusicDuration?.Invoke(duration, null);
            return duration;
        }

        internal void clear()
        {
            SelMusic.Clear();
            this.dataGridView1.DataSource = null;
            this.dataGridView2.DataSource = null;
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            GetDuration();
        }
    }
}

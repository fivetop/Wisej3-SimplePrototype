using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.win
{
    public partial class Comp_Music : Wisej.Web.UserControl
    {
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
            this.dataGridView1.DataSource = gweb.mainFrame.dBSqlite.Ds1.Musics.ToList();
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
            }
            catch (Exception e1)
            {
            }
        }

    }
}

using DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Views
{
    public partial class View_SystemTest : Wisej.Web.UserControl
    {
        public View_SystemTest()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        List<AssetsRow> SelAsset { get; set; } = new List<AssetsRow>();
        List<MusicsRow> SelMusic { get; set; } = new List<MusicsRow>();

        int bSTreeid { get; set; } = 0;


        private async void button1_Click(object sender, EventArgs e)
        {
            var o1 = comboBox1.SelectedItem; // .ㄴㄷ .SelectedIndex + 1;
            int i1 = int.Parse(o1.ToString());

            if (i1 < 529 || i1 > 536)
            {
                i1 = 530;
            }

            bSTreeid = i1;
            SelAsset.Clear();
            SelMusic.Clear();
            var t1 = gweb.dBSqlite.Ds1.Assets.FirstOrDefault(p => p.AssetId == 143);
            SelAsset.Add(t1);
            var t2 = gweb.dBSqlite.Ds1.Musics.FirstOrDefault(p => p.MusicId == 3);
            SelMusic.Add(t2);

            await gweb.dBSqlite.BSTreeCRemove(bSTreeid);
            await gweb.dBSqlite.BSTreeCSave(bSTreeid, SelAsset, SelMusic, gweb.mainFrame.user_name);
            await gweb.dBSqlite.BSTreeUpdate(bSTreeid, "방송시작");
            await gweb.mainFrame.sendSigR(eSignalRMsgType.ePlay, bSTreeid, SelAsset, SelMusic);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var o1 = comboBox2.SelectedItem; // .ㄴㄷ .SelectedIndex + 1;
            int i1 = int.Parse(o1.ToString());

            if (i1 < 521 || i1 > 528)
            {
                i1 = 522;
            }

            bSTreeid = i1;
            SelAsset.Clear();
            SelMusic.Clear();
            var t1 = gweb.dBSqlite.Ds1.Assets.FirstOrDefault(p => p.AssetId == 141);
            SelAsset.Add(t1);
            var t2 = gweb.dBSqlite.Ds1.Musics.FirstOrDefault(p => p.MusicId == 3);
            SelMusic.Add(t2);

            await gweb.dBSqlite.BSTreeCRemove(bSTreeid);
            await gweb.dBSqlite.BSTreeCSave(bSTreeid, SelAsset, SelMusic, gweb.mainFrame.user_name);
            await gweb.dBSqlite.BSTreeUpdate(bSTreeid, "방송시작");
            await gweb.mainFrame.sendSigR(eSignalRMsgType.ePlay, bSTreeid, SelAsset, SelMusic);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

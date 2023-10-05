using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Components
{
    public partial class Comp_BBSAnchorPresetQuick : Wisej.Web.UserControl
    {
        public Comp_BBSAnchorPresetQuick()
        {
            InitializeComponent();
        }

        private void Comp_BBSAnchorPresetQuick_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            this.presetTableAdapter1.Fill(this.dataSet11.Preset);
            this.presetCTableAdapter1.Fill(this.dataSet11.PresetC);

            reDraw();

            
        }

        public void reDraw()
        {
            foreach (var p1 in this.dataSet11.Preset)
            {
                Comp_PresetNameCard2 ui = new Comp_PresetNameCard2(p1);
                var t1 = PresetCGetAssets(p1.PresetId);
                var t2 = PresetCGetMusic(p1.PresetId);
                ui.ZoneName = t1[0].ZoneName;
                ui.MusicName = t2[0].FileName;
                ui.ZoneCount = t1.Count();
                ui.MusicCount = t2.Count();
                ui.setCardText();
                ui.ClickedEventHandler += Ui_PresetClickedEventHandler;
                this.panelList.Controls.Add(ui);
            }
        }

        private void Ui_PresetClickedEventHandler(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        // 해당 프리셋의 차일드 가져오기 
        private List<AssetsRow> PresetCGetAssets(int id)
        {
            List<AssetsRow> list = new List<AssetsRow>();
            var rt1 = gweb.dBSqlite.Ds1.PresetC.Where(p => p.PresetId == id && p.MusicId == 0);

            foreach (var r in rt1)
            {
                var m1 = gweb.dBSqlite.Ds1.Assets.FirstOrDefault(p => p.AssetId == r.AssetId);
                if (m1 == null) continue;
                list.Add(m1);
            }
            return list;
        }

        // 해당 프리셋의 차일드 가져오기 
        private List<MusicsRow> PresetCGetMusic(int id)
        {
            List<MusicsRow> list = new List<MusicsRow>();
            var rt1 = gweb.dBSqlite.Ds1.PresetC.Where(p => p.PresetId == id && p.AssetId == 0);

            foreach (var r in rt1)
            {
                var m1 = gweb.dBSqlite.Ds1.Musics.FirstOrDefault(p => p.MusicId == r.MusicId);
                if (m1 == null) continue;
                list.Add(m1);
            }
            return list;
        }


    }
}

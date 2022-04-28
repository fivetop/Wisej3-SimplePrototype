using gClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisej.CodeProject;
using Wisej.CodeProject.DataSet1TableAdapters;
using static Wisej.CodeProject.DataSet1;

namespace LSNAudio
{
    public class DBSqlite
    {
        public DataSet1 ds1 { get; set; }
        public TableAdapterManager dm1 { get; internal set; }

        public DBSqlite()
        {
        }

        public void DBInit()
        {
            try
            {
                ds1 = new DataSet1();
                dm1 = new TableAdapterManager()
                {
                    SimplepaTableAdapter = new SimplepaTableAdapter(),
                    BSTreeTableAdapter = new BSTreeTableAdapter(),
                    MusicsTableAdapter = new MusicsTableAdapter(),
                };
                dm1.SimplepaTableAdapter.Fill(ds1.Simplepa);
                dm1.BSTreeTableAdapter.Fill(ds1.BSTree);
                dm1.MusicsTableAdapter.Fill(ds1.Musics);
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }


    }
}

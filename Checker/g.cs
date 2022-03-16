using gClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checker
{
	static public class g
	{
		static public MainWindow MainWindow;
		static public string old_log = "";

		static public void Log(string log)
		{
			if (log == old_log)
				return;
			old_log = log;

			try
			{
				DateTime t = DateTime.Now;
				string str1 = t.ToString() + " : " + log;
				g.MainWindow.Log(str1);
				string fn = "spk_" + DateTime.Now.Year.ToString();
				StreamWriter writer = new StreamWriter(File.Open(gl.appPathServer_log + fn + ".txt", FileMode.Append));
				writer.WriteLine(str1);
				writer.Close();
				Console.WriteLine(str1);

			}
			catch (Exception e1)
			{
				//Console.WriteLine(e1.Message);
			}
		}
	}
}

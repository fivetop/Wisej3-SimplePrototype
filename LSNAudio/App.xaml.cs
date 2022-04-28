using gClass;
using System.Windows;

namespace LSNAudio
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            gl.InitSimplePA();
            //string[] t1 = new string[] { "PreMusic", "A Maidens Prayer.mp3" };
            //string[] t1 = new string[] { "3", "0" }; // 0 : sound card id , 1: multi bs id 
            string[] t1 = new string[] { "1", "999999" }; // 0 : sound card id , 1: multi bs id 
            // PreMusic Amaryllis.mp3
            ///*
            if (e.Args[0] == "PreMusic")
            {
                MainWindow2 window2 = new MainWindow2();
                window2.e1 = e.Args;
                window2.Show();
                return;
            }
            else if (e.Args[0] == "999999")
            {
                MainWindow3 window3 = new MainWindow3();
                if (e.Args.Length < 1)
                    window3.e1 = t1;
                else
                    window3.e1 = e.Args;
                window3.Show();
                return;
            }
            else if (e.Args[0] == "1")
            {
                MainWindow4 window4 = new MainWindow4();
                if (e.Args.Length < 1)
                    window4.e1 = t1;
                else
                    window4.e1 = e.Args;
                window4.Show();
                return;
            }
            //*/
            MainWindow window = new MainWindow();
            if (e.Args.Length < 1)
                window.e1 = t1;
            else
                window.e1 = e.Args;
            //window.e1 = t1; // debug
            window.Show();
        }
    }
}

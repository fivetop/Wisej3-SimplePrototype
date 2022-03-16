using gClass;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace LSmDNSW
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // 가장 먼저 시작되는 곳...
            StartApp();
        }

        public void StartApp()
        {
            // 기본(대표) 리소스 화일명을 등록
        }

        Mutex _mutex = null;
        protected override void OnStartup(StartupEventArgs e)
        {
            // 두 번쨰로 시작되는 곳...
            string mutex_name = "LSmDNSW";
            bool isCreateNew = false;

            try
            {
                _mutex = new Mutex(true, mutex_name, out isCreateNew);
                if (isCreateNew)
                {
                    gl.InitSimplePA();
                    base.OnStartup(e);
                }
                else
                {
                    Application.Current.Shutdown();
                }
            }
            catch (Exception ex)
            {
                Application.Current.Shutdown();
            }
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {

            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            // 로긴 후에 데이터 준비 기간 동안 프로그래스 바를 보여준다.
            var mainWindow = new MainWindow();
            Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            Current.MainWindow = mainWindow;
            mainWindow.Show();
        }


        private void Application_Exit(object sender, ExitEventArgs e)
        {

        }

    }
}

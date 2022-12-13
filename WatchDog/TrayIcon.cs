using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchDog
{
    public class TrayIcon
    {
        private NotifyIcon _icon;

        public TrayIcon()
        {
            _icon = new NotifyIcon
            {
                Visible = false,
                Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location),
                Text = "Checker",
            };
            _icon.DoubleClick += _icon_DoubleClick;
        }

        protected virtual void Dispose(bool native)
        {
            if (_icon != null)
            {
                _icon.Dispose();
                _icon = null;
            }
            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public void MinimizeToTray()
        {
            _icon.Visible = true;
            App.Current.MainWindow.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void _icon_DoubleClick(object sender, EventArgs e)
        {
            _icon.Visible = false;
            App.Current.MainWindow.Visibility = System.Windows.Visibility.Visible;
        }
    }
}

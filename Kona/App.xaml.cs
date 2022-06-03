using System;
using System.Windows;
using Hardcodet.Wpf.TaskbarNotification;

namespace Kona
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private TaskbarIcon notifyIcon;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            notifyIcon = (TaskbarIcon)FindResource("NotifyIcon");

            MainWindow = new MainWindow();
            MainWindow.Hide();

            GlobalHotKeys.Register("Alt + Space", () => ToggleMainWindow());
        }

        void OnDeactivated(object sender, EventArgs e)
        {
            MainWindow.Hide();
        }

        private void ToggleMainWindow()
        {
            if (MainWindow.Visibility == Visibility.Visible)
            {
                MainWindow.Hide();
            }
            else
            {
                MainWindow.Show();
            }
        }

        protected override void OnExit(ExitEventArgs e)
        {
            notifyIcon.Dispose();
            base.OnExit(e);
        }
    }
}

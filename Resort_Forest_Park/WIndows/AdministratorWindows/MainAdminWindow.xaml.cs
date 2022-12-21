using Resort_Forest_Park.WIndows.ShiftSupervisorWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Resort_Forest_Park.WIndows.AdministratorWindows
{
    /// <summary>
    /// Логика взаимодействия для MainAdminWindow.xaml
    /// </summary>
    public partial class MainAdminWindow : Window
    {
        DispatcherTimer timer;
        public MainAdminWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Start();
        }
        int timeLogin = 1;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLogin > 60)
            {
                timer.Stop();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                TbTimer.Text = $"{60 - timeLogin}";
                timeLogin++;
            }
        }

        private void HistoryLogin_Click(object sender, RoutedEventArgs e)
        {
            HistotyLoginWindow window = new HistotyLoginWindow();
            window.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void AllOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow window = new OrderWindow();
            window.ShowDialog();
        }
    }
}

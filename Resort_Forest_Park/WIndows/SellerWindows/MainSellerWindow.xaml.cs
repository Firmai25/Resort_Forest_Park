using Resort_Forest_Park.Entities;
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

namespace Resort_Forest_Park.WIndows.SellerWindows
{
    /// <summary>
    /// Логика взаимодействия для MainSellerWindow.xaml
    /// </summary>
    public partial class MainSellerWindow : Window
    {
        DispatcherTimer timer;
        Forest_ParkEntities db = new Forest_ParkEntities();
        public MainSellerWindow()
        {
            InitializeComponent();
            TbTimer.Text = $"{timeMin}:{timeSec}";
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Start();
        }
        int timeSec = 59;
        int timeMin = 9;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeSec == 0 && timeMin == 0)
            {
                timer.Stop();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                if (timeSec == 0)
                {
                    timeMin--;
                    timeSec = 60;
                }
                TbTimer.Text = $"{timeMin}:{timeSec}";
                timeSec--;
            }

        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow(db);
            addUserWindow.Owner = this;
            addUserWindow.ShowDialog();
        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindow addOrderWindow = new AddOrderWindow();
            addOrderWindow.ShowDialog();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}

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
using Resort_Forest_Park.Entities;

namespace Resort_Forest_Park.WIndows
{
    /// <summary>
    /// Логика взаимодействия для InfoUserWindow.xaml
    /// </summary>
    public partial class InfoUserWindow : Window
    {
        DispatcherTimer timer;

        public InfoUserWindow(Worker worker)
        {
            InitializeComponent();
            DataContext= worker;
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 2);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}

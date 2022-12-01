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
using Resort_Forest_Park.Entities;
using Resort_Forest_Park.WIndows.SellerWindows;

namespace Resort_Forest_Park.WIndows.ShiftSupervisorWindows
{
    /// <summary>
    /// Логика взаимодействия для MainSupervisorWindow.xaml
    /// </summary>
    public partial class MainSupervisorWindow : Window
    {
        Forest_ParkEntities db = new Forest_ParkEntities();
        public MainSupervisorWindow()
        {
            InitializeComponent();
        }

        private void Accept_the_goods_click(object sender, RoutedEventArgs e)
        {
            AcceptTheGoodsWindow acceptTheGoodsWindow = new AcceptTheGoodsWindow();
            acceptTheGoodsWindow.Show();
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow(db);
            addUserWindow.Show();
        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindow addOrderWindow = new AddOrderWindow();
            addOrderWindow.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}

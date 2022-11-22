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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Resort_Forest_Park.Entities;
using Resort_Forest_Park.WIndows.SellerWindows;

namespace Resort_Forest_Park
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Forest_ParkEntities db = new Forest_ParkEntities();
            Worker worker = db.Workers.Where(b => b.Name == TbName.Text && b.Password == PbPassword.Password).FirstOrDefault();
            if (worker != null)
            {
                switch(worker.TypeWorker.Name)
                {
                    case "Администратор":

                        break;
                    case "Продавец":
                        MainSellerWindow mainSellerWindow = new MainSellerWindow();
                        mainSellerWindow.Show();
                        Close();
                        break;
                    case "Старший смены":

                        break;
                }
            }
            else
            {
                MessageBox.Show("Вы ввели неправильные данные");
            }
        }
    }
}

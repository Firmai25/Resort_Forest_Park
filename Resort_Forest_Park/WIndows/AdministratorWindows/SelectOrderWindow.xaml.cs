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

namespace Resort_Forest_Park.WIndows.AdministratorWindows
{
    /// <summary>
    /// Логика взаимодействия для SelectOrderWindow.xaml
    /// </summary>
    public partial class SelectOrderWindow : Window
    {
        Forest_ParkEntities db = new Forest_ParkEntities();
        public SelectOrderWindow(Order order)
        {
            InitializeComponent();

            var que =
                from ord in db.Orders
                from ser in db.Services
                from ordSer in db.OrderServices
                where ord.ID == ordSer.ID_Order && ser.ID == ordSer.ID_Services &&
                      ord.ID == order.ID
                select new { Service = ser.Name_service };
            LvService.ItemsSource= que.ToList();


        }

        private void Exit_click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

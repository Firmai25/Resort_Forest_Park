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

namespace Resort_Forest_Park.WIndows.ShiftSupervisorWindows
{
    /// <summary>
    /// Логика взаимодействия для AcceptTheGoodsWindow.xaml
    /// </summary>
    public partial class AcceptTheGoodsWindow : Window
    {
        Forest_ParkEntities db = new Forest_ParkEntities();
        public AcceptTheGoodsWindow()
        {
            InitializeComponent();
            CbOrder.ItemsSource = db.Orders.ToList();
        }
        Order order;
        private void CbOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            order = (Order)comboBox.SelectedItem;
            var que =
                from ord in db.Orders
                from ser in db.Services
                from ordSer in db.OrderServices
                where ord.ID == ordSer.ID_Order && ser.ID == ordSer.ID_Services &&
                      ord.ID == order.ID
                select new {Service = ser.Name_service};

            LvService.ItemsSource = que.ToList();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Service service = db.Services.Where(b=> b.Name_service == checkBox.Content.ToString()).FirstOrDefault();
            OrderService orderService = db.OrderServices.Where(b => b.ID_Services == service.ID && b.ID_Order == order.ID).FirstOrDefault();
            db.OrderServices.Remove(orderService);
            db.SaveChanges();
            var que =
                from ord in db.Orders
                from ser in db.Services
                from ordSer in db.OrderServices
                where ord.ID == ordSer.ID_Order && ser.ID == ordSer.ID_Services &&
                      ord.ID == order.ID
                select new { Service = ser.Name_service };

            LvService.ItemsSource = que.ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

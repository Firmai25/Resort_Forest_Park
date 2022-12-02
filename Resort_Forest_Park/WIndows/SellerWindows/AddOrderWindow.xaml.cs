using Resort_Forest_Park.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace Resort_Forest_Park.WIndows.SellerWindows
{
    /// <summary>
    /// Логика взаимодействия для AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        Forest_ParkEntities db = new Forest_ParkEntities();
        public AddOrderWindow()
        {
            InitializeComponent();
            CbClient.ItemsSource = db.Clients.ToList();
            LvService.ItemsSource = db.Services.ToList();
        }

        public AddOrderWindow(Client client)
        {
            InitializeComponent();
            CbClient.ItemsSource = db.Clients.ToList();
            CbClient.Text = client.Name;
            LvService.ItemsSource = db.Services.ToList();
        }
        string[] masStr = new string[0];
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            string[] masStr2 = new string[masStr.Count() + 1];
            for (int i = 0; i < masStr.Count(); i++)
            {
                masStr2[i] = masStr[i];
            }
            masStr = masStr2;
            masStr[masStr.Count() -1 ] = checkBox.Content.ToString();
            
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            masStr = masStr.Where(val => val != checkBox.Content.ToString()).ToArray();
        }

        private void CreateOrder_click(object sender, RoutedEventArgs e)
        {
            if(CbClient.Text != "")
            {
                if(masStr.Length > 0)
                {
                    Random rnd = new Random();
                    Order order = new Order()
                    {
                        Date_of_creation = DateTime.Now.Date,
                        Order_time = DateTime.Now.TimeOfDay,
                        Client_Code = Convert.ToInt32(CbClient.Text),
                        Status = "В прокате",
                        Rental_time = TbTime.Text + " " + CbTime.Text
                    };
                    bool tr = false;
                    while(tr == false)
                    {
                        int code = rnd.Next(10000000, 99999999);
                        Order searchOrder = db.Orders.Where(b => b.Order_code == code).FirstOrDefault();
                        if(searchOrder == null)
                        {
                            tr = true;
                            order.Order_code= code;
                        }
                    }
                    db.Orders.Add(order);
                    db.SaveChanges();
                    for (int i = 0; i< masStr.Length; i++)
                    {
                        string ser = masStr[i];
                        Service service = db.Services.Where(b => b.Name_service== ser).FirstOrDefault();
                        OrderService orderService = new OrderService()
                        {
                            ID_Order = order.ID,
                            ID_Services= service.ID
                        };
                        db.OrderServices.Add(orderService);
                        db.SaveChanges();
                        MessageBox.Show("Заказ успешно создан");
                        Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Не выбрана не одна услуга");
                }
            }
            else
            {
                MessageBox.Show("Не выбран клиент");
            }
        }
    }
}

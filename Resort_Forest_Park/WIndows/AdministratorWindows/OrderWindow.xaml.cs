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
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        Forest_ParkEntities db = new Forest_ParkEntities();
        public OrderWindow()
        {
            InitializeComponent();
            DgOrder.ItemsSource = db.Orders.ToList();
        }

        private void DgOrder_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var rowselected = DgOrder.SelectedItem;
            if (rowselected != null)
            {
                SelectOrderWindow window = new SelectOrderWindow((Order)rowselected);
            }
            else
            {
                MessageBox.Show("Не выбрана строка");
            }    
        }

        private void OrderSelect_Click(object sender, RoutedEventArgs e)
        {
            var rowselected = DgOrder.SelectedItem;
            if (rowselected != null)
            {
                SelectOrderWindow window = new SelectOrderWindow((Order)rowselected);
                window.Show();
            }
            else
            {
                MessageBox.Show("Не выбрана строка");
            }
        }
    }
}

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

namespace Resort_Forest_Park.WIndows.SellerWindows
{
    /// <summary>
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        Forest_ParkEntities db;
        public AddUserWindow(Forest_ParkEntities database)
        {
            InitializeComponent();
            DataContext = new Client();
            db = database;
        }

        private void CreateClientandService_Click(object sender, RoutedEventArgs e)
        {
            Client client = (Client)DataContext;
            if(CheckClient(client))
            {
                Random random = new Random();
                bool poisc = false;
                while (poisc == false)
                {
                    int i = random.Next(10000000, 99999999);
                    Client cl = db.Clients.Where(b => b.Code_Client== i).FirstOrDefault();
                    if (client == null)
                    {
                        poisc= true;
                        client.Code_Client = i;
                    }
                }
                db.Clients.Add(client);
                db.SaveChanges();
                AddOrderWindow addOrderWindow = new AddOrderWindow(client);
                addOrderWindow.Show();
                Close();
            }

        }

        private bool CheckClient(Client client)
        {
            string error = "";
            if (client.Surname == "")
            {
                error += "Введите фамилию \n";
            }
            if (client.Name == "")
            {
                error += "Введите имя \n";
            }
            if (client.Patronymic == "")
            {
                error += "Введите отчество\n";
            }
            int ser = Convert.ToInt32(client.Series);
            if (ser <= 1000 || ser >= 9999)
            {
                error += "Не правильно введёна серия\n";
            }
            int num = Convert.ToInt32(client.Number);
            if (num <= 100000 || num >= 999999)
            {
                error += "Не правильно введён номер\n";
            }
            if (client.Date_of_birth.ToString() == "")
            {
                error += "Не правильная дата";
            }
            int pos = Convert.ToInt32(client.Postal_code);
            if (pos <= 9999)
            {
                error += "Не правильный почтовый индекс\n";
            }
            if (client.Address == "")
            {
                error += "Не введён адресс\n";
            }
            if (client.Email == "")
            {
                error += "Не введён email\n";
            }
            if (client.password == "")
            {
                error += "Не введён пароль\n";
            }
            if (error == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(error);
                return false;
            }
        }
        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void CreateClient_Click(object sender, RoutedEventArgs e)
        {
            Client client = (Client)DataContext;
            if (CheckClient(client))
            {
                db.Clients.Add(client);
                db.SaveChanges();
                Close();
            }
        }
    }


}

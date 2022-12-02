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
    /// Логика взаимодействия для HistotyLoginWindow.xaml
    /// </summary>
    public partial class HistotyLoginWindow : Window
    {
        Forest_ParkEntities db = new Forest_ParkEntities();
        public HistotyLoginWindow()
        {
            InitializeComponent();
            DgHistory.ItemsSource = db.LoginHistories.ToList();
            CmLogin.ItemsSource = db.Workers.ToList();
        }

        private void CmLogin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            try
            {
                Worker worker = comboBox.SelectedItem as Worker;
                DgHistory.ItemsSource = db.LoginHistories.Where(b => b.Worker.ID == worker.ID).ToList();
            }
            catch { 
            }
            



        }

        private void Clear_click(object sender, RoutedEventArgs e)
        {
            CmLogin.Text = "";
            DgHistory.ItemsSource = db.LoginHistories.ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

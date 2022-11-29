using Resort_Forest_Park.Entities;
using Resort_Forest_Park.WIndows;
using Resort_Forest_Park.WIndows.AdministratorWindows;
using Resort_Forest_Park.WIndows.SellerWindows;
using Resort_Forest_Park.WIndows.ShiftSupervisorWindows;
using System;
using System.Linq;
using System.Windows;

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
        int CountError = 0;
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Forest_ParkEntities db = new Forest_ParkEntities();
            Worker worker = db.Workers.Where(b => b.Login == TbName.Text && b.Password == PbPassword.Password).FirstOrDefault();
            if (worker != null)
            {
                LoginHistory loginHistory = new LoginHistory();
                loginHistory.ID_Worker = worker.ID;
                loginHistory.Type_Login = "Успешно";
                loginHistory.Time_Login = DateTime.Now.ToString();
                db.LoginHistories.Add(loginHistory);
                db.SaveChanges();
                InfoUserWindow infoUserWindow = new InfoUserWindow(worker);
                infoUserWindow.Owner = this;
                infoUserWindow.ShowDialog();
                switch (worker.TypeWorker.Name)
                {

                    case "Администратор":
                        MainAdminWindow mainAdminWindow = new MainAdminWindow();
                        mainAdminWindow.Show();
                        Close();
                        break;
                    case "Продавец":
                        MainSellerWindow mainSellerWindow = new MainSellerWindow();
                        mainSellerWindow.Show();
                        Close();
                        break;
                    case "Старший смены":
                        MainSupervisorWindow mainSupervisorWindow = new MainSupervisorWindow();
                        mainSupervisorWindow.Show();
                        Close();
                        break;
                }
            }
            else
            {
                worker = db.Workers.Where(b => b.Login == TbName.Text).FirstOrDefault();
                if (worker != null)
                {
                    LoginHistory loginHistory = new LoginHistory();
                    loginHistory.ID_Worker = worker.ID;
                    loginHistory.Type_Login = "Неуспешно";
                    loginHistory.Time_Login = DateTime.Now.ToString();
                    db.LoginHistories.Add(loginHistory);
                    db.SaveChanges();
                }
                MessageBox.Show("Вы ввели неправильные данные");
                CountError++;
                if (CountError > 2)
                {
                    CaptchaWindow captchaWindow = new CaptchaWindow();
                    captchaWindow.Owner = this;
                    captchaWindow.ShowDialog();
                    if (captchaWindow.Block == true)
                    {
                        MainGrid.IsEnabled = false;
                    }
                }
            }
        }
    }
}

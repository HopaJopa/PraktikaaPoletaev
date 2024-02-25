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

namespace MagazTurizmaPoletaev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var login = autologin.Text;
            var pass = autopassword.Text;
            var context = new AppDbContext();

            var user_exists = context.Users.FirstOrDefault(x => x.login == login);
            var user_exists2 = context.Users.FirstOrDefault(x => x.password == pass);
            if (user_exists != null && user_exists2 != null)
            {
                this.Hide();
                Katalog katalog = new Katalog();
                katalog.Show();
                MessageBox.Show("Ты зашел в аккаунт, абалдеть!");
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль, разуй глаза, балбес!");
            }
        }
    }
}

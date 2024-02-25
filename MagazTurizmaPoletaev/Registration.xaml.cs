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

namespace MagazTurizmaPoletaev
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var login = reglogin.Text;
            var pass = regpassword.Text;
            var context = new AppDbContext();

            var user_exists = context.Users.FirstOrDefault(x => x.login == login);
            if (user_exists != null)
            {
                MessageBox.Show("Такой пользователь уже есть вообще-то, балбес!");
                return;
            }
            var user = new User { login = login, password = pass };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Ты упешно зарегистрировалися, какой-же ты гений!");
            this.Hide();
            Katalog katalog = new Katalog();
            katalog.Show();
        }
    }
}

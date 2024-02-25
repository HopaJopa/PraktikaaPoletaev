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
    /// Логика взаимодействия для korzina.xaml
    /// </summary>
    public partial class korzina : Window
    {
        public korzina()
        {
            InitializeComponent();
            var context = new AppDbContext();
            var allRecords = context.korzi.ToList();
            lv.ItemsSource = allRecords;
            var sum = context.korzi.Select(x => x.cost).ToList();
            var itog = sum.Sum();
            tb.Text = Convert.ToString($"{itog}р");

            var sumTov = context.korzi.Select(x => x.id).ToList();
            var itogTov = sumTov.Count();
            tb1.Text = Convert.ToString(itogTov);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Katalog katalog = new Katalog();
            katalog.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ оплачен успешно!");
        }
    }
}

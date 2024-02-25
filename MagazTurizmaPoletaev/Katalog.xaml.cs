using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
    /// Логика взаимодействия для Katalog.xaml
    /// </summary>
    public partial class Katalog : Window
    {
        public Katalog()
        {
            InitializeComponent();
            var context = new AppDbContext();
            var vse = context.products.ToList();
            lv.ItemsSource = vse;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var context = new AppDbContext();
            var aboba = context.products.SingleOrDefault(x => x.id == lv.SelectedIndex + 1);
            if (aboba != null)
            {
                var a = new korz { nazvan = aboba.nazv, kratkOp = aboba.kratkOpis, cost = aboba.price, image = aboba.img };
                context.korzi.Add(a);
            }
            context.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            korzina korzina = new korzina();
            korzina.Show();
        }
    }
}

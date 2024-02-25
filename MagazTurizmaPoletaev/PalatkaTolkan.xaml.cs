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
    /// Логика взаимодействия для PalatkaTolkan.xaml
    /// </summary>
    public partial class PalatkaTolkan : Window
    {
        public PalatkaTolkan()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Katalog katalog = new Katalog();
            katalog.Show();
        }
    }
}

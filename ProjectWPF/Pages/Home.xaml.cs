using ProjectWPF.Windows;
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

namespace ProjectWPF.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            Label s = new Label();
            s.Content = MainWindow.s;
            s.FontSize = 15;
            Zagolovok.Children.Add(s);
        }

        private void AddCar_Click(object sender, RoutedEventArgs e)
        {
            Add_Car ac = new Add_Car();
            ac.Show();
        }

        private void CarInfo_Click(object sender, RoutedEventArgs e)
        {
            AboutMashina am = new AboutMashina();
            am.Show();
        }
    }
}

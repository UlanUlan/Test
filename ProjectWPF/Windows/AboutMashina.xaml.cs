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

namespace ProjectWPF.Windows
{
    /// <summary>
    /// Interaction logic for AboutMashina.xaml
    /// </summary>
    public partial class AboutMashina : Window
    {
        public AboutMashina()
        {
            InitializeComponent();
        }

        private void CloseAboutM_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

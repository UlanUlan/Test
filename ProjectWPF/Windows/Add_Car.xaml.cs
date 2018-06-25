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
    /// Interaction logic for Add_Car.xaml
    /// </summary>
    public partial class Add_Car : Window
    {
        public Add_Car()
        {
            InitializeComponent();
        }

        private void ComboBoxPolnStoim_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PolnayaStoimost.Text = ComboBoxPolnStoim.SelectionBoxItem.ToString();
        }

        private void ComboBoxSrokSluzhby_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SrokSluzhby.Text = ComboBoxSrokSluzhby.SelectionBoxItem.ToString();
        }

        private void ComboBoxKoefficientUskoreniya_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            KoefficientUskoreniya.Text = ComboBoxKoefficientUskoreniya.SelectionBoxItem.ToString();
        }
    }
}

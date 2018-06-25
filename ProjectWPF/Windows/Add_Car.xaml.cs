using CarDB.DAL.Models;
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
        private Model1 db = new Model1();
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

        private void AddM_Click(object sender, RoutedEventArgs e)
        {
            //newEquipment eq = new newEquipment();
            //eq.intGarageRoom = GarazhNomer.Text;
            //eq.intManufacturerID = Convert.ToInt32(Manufacturer.Text);
            //eq.intModelID = Convert.ToInt32(Model.Text);
            //eq.strManufYear = YearOfIssue.Text;
            //eq.intSNPrefixID = Convert.ToInt32(SerialNumber.Text);
            //eq.intLastMetered = Convert.ToInt32(LastMotohouers.Text);
            //eq.intTotalMetered = Convert.ToInt32(TotalWork.Text);
            Console.WriteLine();
        }
    }
}

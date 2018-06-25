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

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string s;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            s = ButtonSpisokmashin.Content.ToString();
            CentralFrame.Source = new Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute);
        }

        private void ComboLang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine();
        }
    }
}

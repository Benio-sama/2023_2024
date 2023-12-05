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

namespace MachKalkulatorGUI
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
        private void Szamol_button(object sender, RoutedEventArgs e)
        {
            try
            {
                double torlo = double.Parse(qc_torlonyomas.Text);
                double statikus = double.Parse(p0_statikus_nyomas.Text);
                double ma = Math.Sqrt(5 * ((Math.Pow((torlo / statikus + 1), (2.0 / 7.0))) - 1));
                Eredmenyek_list.Items.Add($"qc = {torlo}, p0 = {statikus} : Ma = {ma}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem megfelelo a bemeneti karakterlanc formatuma", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}

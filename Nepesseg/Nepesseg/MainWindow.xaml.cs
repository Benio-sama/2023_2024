using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nepesseg
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
        private void MentesgombClick(object sender, RoutedEventArgs e)
        {
            string orszag = orszagLabel.Text;
            int terulet = int.Parse(teruletLabel.Text);
            long nepesseg = long.Parse(nepessegLabel.Text);
            string fovaros = fovarosLabel.Text;
            long fovnepesseg = long.Parse(fovarnepLabel.Text);
            if (fovnepesseg > nepesseg)
            {
                fovarnepLabel.Text = nepesseg.ToString();
                message.Content = "a fovaros lakossaga nem lehet tobb a nepessegnel"; //azert nem csinaltam vegul messagebox-szal mert a feladatban nem ugyy mutatta
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("ujAdat.txt", true))
                {
                    sw.WriteLine($"{orszag};{terulet};{nepesseg};{fovaros};{fovnepesseg}");
                }
                message.Content = "sikeres mentes";
            }
        }
        private void KilepesgombClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

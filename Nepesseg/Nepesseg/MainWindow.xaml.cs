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
            Feladatok f = new Feladatok();
            f.Beolvas("adatok-utf8.txt");
            f.Hany();
            f.Nepsuruseg();
            f.KinaVsIndia();
            f.Elso3();
            f.MeghaladjaE();
            /*<Border CornerRadius="80">
            <Grid Margin="334,22,334,373">
            <Label FontSize="40" Margin="-109,-25,-109,-25" Content="Új ország felvétele"/>
            <TextBox Margin="-78,86,-77,-76"/>
            <Label FontSize="15" Content="Ország:" Margin="-151,84,230,-79"/>
            <TextBox Margin="-78,129,-77,-119"/>
            <Label FontSize="15" Content="Terület:" Margin="-151,126,230,-123"/>
            <TextBox Margin="-78,172,-77,-162"/>
            <Label FontSize="15" Content="Népesség:" Margin="-172,170,230,-164"/>
            <TextBox Margin="-78,210,-77,-200"/>
            <Label FontSize="15" Content="Főváros:" Margin="-162,208,231,-202"/>
            <TextBox Margin="-78,253,-77,-243"/>
            <Label FontSize="15" Content="Főváros lakossága:" Margin="-232,251,232,-245"/>
            <Label FontSize="14" Content="Kérem adja meg az adatokat!" Margin="-28,308,-27,-308"/>
            <Button Margin="329,358,-308,-351">Kilépés</Button>
            <Button Margin="286,162,-265,-173">Mentés</Button>
        </Grid>
    </Border>*/
        }
        private void MentesgombClick(object sender, RoutedEventArgs e)
        {
            long nepesseg = long.Parse(nepessegLabel.Text);
            long fovnepesseg = long.Parse(fovarnepLabel.Text);
            if (fovnepesseg > nepesseg)
            {
                MessageBox.Show("a fovaros lakossaga nem lehet tobb a nepessegnel");
                return;
            }
        }
        private void KilepesgombClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

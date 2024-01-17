using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Pars2012;
using System.Windows.Media.Imaging;
using System.IO;

namespace Pars2012GUI
{
    public partial class MainWindow : Window
    {
        private List<Versenyzo> versenyzoList = new List<Versenyzo>(); 

        public MainWindow()
        {
            using (StreamReader sr = new StreamReader("Selejtezo2012.txt"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    Versenyzo v = new Versenyzo(sr.ReadLine());
                    versenyzoList.Add(v);
                }
            }
            InitializeComponent();
            foreach (var item in versenyzoList)
            {
                Nev.Items.Add(item.Nev);
                if (item.Nev == "Pars Krisztián")
                {
                    Nev.SelectedItem = item.Nev;
                }
            }
        }

        private void Nev_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            Versenyzo versenyzo = versenyzoList[box.SelectedIndex];
            Csoport.Content = $"Csoport: {versenyzo.Csoport}";
            Nemzet.Content = $"Nemzet: {versenyzo.Nemzet()}";
            NemzetKod.Content = $"Nemzet kód: {versenyzo.Kod()}";
            Sorozat.Content = $"Sorozat: {versenyzo.Sorozat()}";
            Eredmeny.Content = $"Eredmény: {versenyzo.Eredmeny()}";
            Uri uri = new Uri("../Images/" + versenyzo.Kod() + ".png", UriKind.Relative);
            zaszlo.Source = new BitmapImage(uri);
        }
    }
}

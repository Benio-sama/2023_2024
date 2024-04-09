using System.Windows;
using System.Windows.Controls;

namespace IngatlanApp
{
    public partial class MainWindow : Window
    {
        private Ingatlanok ingatlanok;

        public MainWindow()
        {
            InitializeComponent();
            ingatlanok = new Ingatlanok(); 
        }

        private void FeladatokListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FeladatokListBox.SelectedItem is ListBoxItem selectedItem)
            {
                switch (selectedItem.Content.ToString())
                {
                    case "Összes eladás száma":
                        EredmenyekTextBlock.Text = $"eladasok szama: {ingatlanok.EladasokSzama()}";
                        break;
                    case "Legnagyobb területű ingatlan":
                        EredmenyekTextBlock.Text = $"legnagyobb teruletu ingatlan: {ingatlanok.Legnagyobb()}";
                        break;
                    case "Összesített eladások értéke":
                        EredmenyekTextBlock.Text = $"osszesitett eladasok erteke: {ingatlanok.Osszes()} FT";
                        break;
                }
            }
        }
    }
}

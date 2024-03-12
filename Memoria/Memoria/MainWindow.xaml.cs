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

namespace Memoria
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public static int valasztottJatek;


		public MainWindow()
		{
			InitializeComponent();
			Alapbeállitasok();


		}
		private void Alapbeállitasok()
		{
			cbox.Items.Add(2);
			cbox.Items.Add(4);
			cbox.Items.Add(6);
			cbox.Items.Add(8);
		}


		private void cbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			valasztottJatek  = int.Parse(cbox.SelectedItem.ToString());
			Jatek j = new Jatek();
			j.Show();
			this.Hide();
		}
	}
}

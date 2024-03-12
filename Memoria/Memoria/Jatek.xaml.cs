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

namespace Memoria
{
	/// <summary>
	/// Interaction logic for Jatek.xaml
	/// </summary>
	public partial class Jatek : Window
	{
		int valasztott;
		List<Button> gombok = new List<Button> ();
		public Jatek()
		{
			InitializeComponent();
			valasztott = MainWindow.valasztottJatek;
			AlapBeallitas();
		}
		private void AlapBeallitas()
		{
			for (int i = 0; i < valasztott; i++)
			{
				racs.RowDefinitions.Add(new RowDefinition());
			}
			for (int i = 0; i < valasztott; i++)
			{
				racs.ColumnDefinitions.Add(new ColumnDefinition());
			}
			racs.ShowGridLines = true;
			
			for (int i = 0; i < valasztott; i++)
			{
				for (int j = 0; j < valasztott; j++)
				{
					Button b = new Button();
					BitmapImage kep = new BitmapImage(new Uri("hatter.jpg", UriKind.RelativeOrAbsolute));
					Image im = new Image();
					im.Source = kep;
					im.Stretch = Stretch.Fill;
					b.Content = im;

					Grid.SetRow(b, i);
					Grid.SetColumn(b, j);
					racs.Children.Add(b);
				}
			}


		}




	}
}

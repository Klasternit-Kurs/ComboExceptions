using System;
using System.Collections.Generic;
using System.IO;
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

namespace Combo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			List<Test> lst = new List<Test>();
			lst.Add(new Test("Jen", "1"));
			lst.Add(new Test("Dva", "2"));
			lst.Add(new Test("Tri", "3"));

			cb.ItemsSource = lst;
			cb.DisplayMemberPath = "ImeIPrezime";

			lv.ItemsSource = lst;
			lv.DisplayMemberPath = "Bla";

			dg.ItemsSource = lst;

			if (System.IO.File.Exists("asd.txt"))
				System.IO.File.ReadAllText("asd.txt");

			try
			{
				string asd = System.IO.File.ReadAllText("asd.txt");
			} catch (FileNotFoundException e)
			{
				MessageBox.Show("Nema fajla");
			} catch
			{
				MessageBox.Show("Nesto peto");
			}
			try
			{
				lst.RemoveAt(1);
			} catch (ArgumentOutOfRangeException e)
			{
				MessageBox.Show("Greska! " + e.Message);
			} catch (ArgumentNullException ee)
			{

			}catch
			{
				MessageBox.Show("Nesto drugo!");
			} finally
			{
				MessageBox.Show("Ovo obavezno");
			}

		}
	}



	public class Test
	{
		public string Bla { get; set; }
		public string BlaBla { get; set; }

		public string ImeIPrezime { get => $"{Bla} {BlaBla}"; }

		public List<string> NekaLista { get; set; } = new List<string>();

		public Test(string jen, string dva)
		{
			Bla = jen;
			BlaBla = dva;
			NekaLista.Add("Nesto");
			NekaLista.Add("Drugo");
			NekaLista.Add("Trece");
		}

	}
}

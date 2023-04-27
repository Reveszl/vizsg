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

namespace BalatonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<adatok> lista = new List<adatok>();
        public MainWindow()
        {
            InitializeComponent();
            combobox1.Items.Add("A");
            combobox1.Items.Add("B");
            combobox1.Items.Add("C");

            StreamReader sr = new StreamReader("utca.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                adatok a = new adatok(sor);
                lista.Add(a);
            }

            datagrid1.ItemsSource = lista;
        }

        private void modosit_Click(object sender, RoutedEventArgs e)
        {
            int db = 0;
            foreach (var item in lista)
            {
                if (db==datagrid1.SelectedIndex)
                {
                    item.Kategoria = combobox1.Text;
                }
                db++;
            }
            datagrid1.Items.Refresh();
        }

        private void mentes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("modositottadok.txt");
                foreach (var item in lista)
                {
                    sw.WriteLine(item.Adoszam + " " + item.Utca + " " + item.Hazszam + " " + item.Kategoria + " " + item.Terulet);
                }
                MessageBox.Show("A mentés sikeres!");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

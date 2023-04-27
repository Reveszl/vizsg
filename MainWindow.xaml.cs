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
using System.IO;

namespace IskolaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                listbox1.Items.Add(sr.ReadLine());
            }

            sr.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listbox1.Items.RemoveAt(listbox1.SelectedIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("Nem jelölt ki tanulót!");
            }
        }

        private void mentes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("nevekNEW.txt");
                for (int i = 0; i < listbox1.Items.Count; i++)
                {
                    sw.WriteLine(listbox1.Items[i].ToString());
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

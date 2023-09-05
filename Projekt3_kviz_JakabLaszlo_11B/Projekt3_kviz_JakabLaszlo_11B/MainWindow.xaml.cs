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

namespace Projekt3_kviz_JakabLaszlo_11B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> tantargyak = new List<string>();
        List<string> temakorok = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            IrodalomBetoltese();
            TortenelemBetoltese();


        }


        private void TortenelemBetoltese()
        {
            string[] allomany1 = File.ReadAllLines("magyartori.txt");
            string alma = allomany1[0].Split(';')[0];

            foreach (string sor in allomany1)
            {
                string tortenelem = sor.Split(';')[0];
                tantargyak.Add(tortenelem);
                tantargyBox.Items.Add(tortenelem);
                break;
            }
            string[] tori1 = File.ReadAllLines("magyartori.txt");
            string magyarTori = tori1[0].Split(';')[0];
            foreach (string sor in tori1)
            {
                string magyarTori1 = sor.Split(';')[1];
                temakorBox.Items.Add(magyarTori1);

                if (tantargyBox.SelectedItem == tori1)
                {
                    temakorBox.Items.Add(magyarTori1);
                }
                break;
            }

            string[] tori2 = File.ReadAllLines("reformkor.txt");
            string reform = tori2[0].Split(';')[0];

            foreach (string sor in tori2)
            {
                string reformkor = sor.Split(';')[1];
                temakorBox.Items.Add(reformkor);
                break;
            }
        }


        private void IrodalomBetoltese()
        {
            string[] irodalom = File.ReadAllLines("irodalom.txt");
            string alma = irodalom[0].Split(';')[0];

            foreach (string sor in irodalom)
            {
                string irodalom1 = sor.Split(';')[0];
                tantargyak.Add(irodalom1);
                tantargyBox.Items.Add(irodalom1);
                break;

                for (int i = 0; i < irodalom.Length; i++)
                {
                    if (tantargyBox.SelectedItem == irodalom)
                    {
                        temakorBox.Items.Add(alma[1]);
                    }
                }
                break;
            }
            foreach (string sor in irodalom)
            {
                string irodalomTema = sor.Split(';')[1];
                temakorBox.Items.Add(irodalomTema);

                if (tantargyBox.SelectedItem == irodalom)
                {
                    temakorBox.Items.Add(irodalomTema);
                }
                break;

            }



        }

       

        private void kilepesGomb_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       

        
    }
}

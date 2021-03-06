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

namespace ProgettoCoppie
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<CD> ListaDeiCD;
        public MainWindow()
        {
            InitializeComponent();
            ListaDeiCD = new List<CD>();
        }

        private void AggiungiBrano_Click(object sender, RoutedEventArgs e)
        {
            string titolo;
            string autore;
            int durata;
            if (string.IsNullOrEmpty(TXTautore.Text) == false)
            {
                if (string.IsNullOrEmpty(TXTtitolo.Text) == false)
                {
                    try
                    {
                        durata = int.Parse(TXTdurata.Text);
                        titolo = TXTtitolo.Text;
                        autore = TXTautore.Text;
                        Brano b = new Brano(titolo, autore, durata);
                        ListaDeiCD[ComboCD.SelectedIndex].addBrano(b);
                    }
                    catch
                    {
                        MessageBox.Show("Creazione non riuscita");
                    }
                }
            }
            AggiornaComboBox();
        }

        private void CreaCD_Click(object sender, RoutedEventArgs e)
        {
            string titolo="";
            string autore="";
            if (string.IsNullOrEmpty(TXTautore.Text) == false)
            {
                if (string.IsNullOrEmpty(TXTtitolo.Text) == false)
                {
                    titolo = TXTtitolo.Text;
                    autore = TXTautore.Text;
                    CD Prova = new CD(titolo, autore);
                    ListaDeiCD.Add(Prova);
                    AggiornaComboBox();
                }
            }
        }
        public void AggiornaComboBox()
        {
            ComboCD.ItemsSource = "";
            ComboCD.ItemsSource = ListaDeiCD;
        }

        private void ComboCD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboCD.SelectedIndex != -1)
            {
                AggiungiBrano.IsEnabled = true;
                RaccogliInfo.IsEnabled = true;
            }
            else
            {
                AggiungiBrano.IsEnabled = false;
                RaccogliInfo.IsEnabled = false;
            }
        }

        private void RaccogliInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Titolo CD:"+ListaDeiCD[ComboCD.SelectedIndex].Titolo+" "+"Autore CD:"+ ListaDeiCD[ComboCD.SelectedIndex].Autore);
            List<Brano> listaBrani = ListaDeiCD[ComboCD.SelectedIndex].Brani;
            MessageBox.Show("Brani:");
            foreach (Brano b in listaBrani)
            {
                MessageBox.Show("Titolo:" + b.Titolo + " " + "Autore:" + b.Autore + " " + "Durata:" + b.Durata.ToString());
            }
        }
    }
}
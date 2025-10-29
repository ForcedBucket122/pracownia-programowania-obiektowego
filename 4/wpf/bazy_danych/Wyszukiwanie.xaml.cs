using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data.MySqlClient;

namespace bazy_danych
{
    /// <summary>
    /// Logika interakcji dla klasy Wyszukiwanie.xaml
    /// </summary>
    public partial class Wyszukiwanie : Window
    {
        public Wyszukiwanie()
        {
            InitializeComponent();
            wyszukaj.Click += Wyszukaj_Click;

        }
        private void Wyszukaj_Click(object sender, RoutedEventArgs e)
        {
            pobieranieIwyswietlanie();
        }

        private void pobieranieIwyswietlanie()

        {
            string danePolaczenia = "server=localhost;user=root;password='';database=4pb";
            MySqlConnection polaczenie = new MySqlConnection(danePolaczenia);
            // pobieranie danych
            try
            {
                String nazwisko1 = Nazwisko.Text;
                polaczenie.Open();
                string kwerenda = $"SELECT uczniowie.id as 'id ucznia',uczniowie.nazwisko,uczniowie.imie as imię,klasa.nazwaKlasy as klasa, wychowawca.nazwisko as 'nazwisko wychowawcy' ,wychowawca.imie as 'imię wychowawcy' ,uczniowie.wplataRR FROM uczniowie INNER JOIN klasa ON uczniowie.klasa=klasa.id INNER JOIN wychowawca ON uczniowie.wychowawca=wychowawca.id WHERE nazwisko LIKE '%{nazwisko1}%'";
                //tworzymy obiekt połaczenia do konstruktora przekazujemy kwerende i połaczenie
                MySqlCommand cmd = new MySqlCommand(kwerenda, polaczenie);


                //adapter obiekt klasy MySqlDataAdapter , który przechowuje informacje potrzebne do komunikacji z bazą danych.
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();//tabela w pamieci
                adapter.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView; //wstawiamy do dataGrid


            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
            finally
            {
                polaczenie.Close();
            }

        }
    }
}

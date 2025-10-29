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

namespace bazy_danych
{
    /// <summary>
    /// Logika interakcji dla klasy Dodawanie.xaml
    /// </summary>
    public partial class Dodawanie : Window
    {
        public Dodawanie()
        {
            InitializeComponent();
            wyswietl.Click += Wyswietl_Click;
            dodaj.Click += Dodaj_Click;
        }
        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            wstawianie();
        }

        private void Wyswietl_Click(object sender, RoutedEventArgs e)
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
                polaczenie.Open();
                string kwerenda = "SELECT uczniowie.id as 'id ucznia',uczniowie.nazwisko,uczniowie.imie as imię,klasa.nazwaKlasy as klasa, wychowawca.nazwisko as 'nazwisko wychowawcy' ,wychowawca.imie as 'imię wychowawcy' ,uczniowie.wplataRR FROM uczniowie INNER JOIN klasa ON uczniowie.klasa=klasa.id INNER JOIN wychowawca ON uczniowie.wychowawca=wychowawca.id";
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


        private void wstawianie()

        {
            string danePolaczenia = "server=localhost;user=root;password='';database=4pb";
            MySqlConnection polaczenie = new MySqlConnection(danePolaczenia);
            // pobieranie danych
            try
            {
                polaczenie.Open();
                string nazwisko1 = nazwisko.Text.Trim();
                string imie1 = imie.Text.Trim();
                int wplata1=0;
                if (!string.IsNullOrWhiteSpace(wplata.Text))
                {
                    wplata1 = int.Parse(wplata.Text);
                }
                int klasa1 = klasa.SelectedIndex + 1;
                int wychowawca1 = wychowawca.SelectedIndex + 1;
                string kwerenda = $@"
    INSERT INTO uczniowie (nazwisko, imie, klasa, wychowawca, wplataRR) 
    VALUES ('{nazwisko1}', '{imie1}', {klasa1}, {wychowawca1}, {wplata1})";

                //bez @
                // string kwerenda = $"INSERT INTO uczniowie (nazwisko, imie, klasa, wychowawca, wplataRR)"+ 
                // $"VALUES ('{nazwisko1}', '{imie1}', {klasa1}, {wychowawca1}, {wplata1})";

                //tworzymy obiekt połaczenia do konstruktora przekazujemy kwerende i połaczenie
                MySqlCommand cmd = new MySqlCommand(kwerenda, polaczenie);
                // 🔥 Wykonanie zapytania
                int wynik = cmd.ExecuteNonQuery();

                if (wynik > 0)
                    MessageBox.Show("Uczeń został usunięty.");
                else
                    MessageBox.Show("Nie udało się dodać ucznia.");


                //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                //DataTable dt = new DataTable();//tabela w pamieci
                //adapter.Fill(dt);
                //dataGrid.ItemsSource = dt.DefaultView; //wstawiamy do dataGrid


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

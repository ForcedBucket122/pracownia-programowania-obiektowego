using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    /// Logika interakcji dla klasy Usuwanie.xaml
    /// </summary>
    public partial class Usuwanie : Window
    {
        public Usuwanie()
        {
            InitializeComponent();
            usun.Click += Usun_Click;
            wyswietl.Click += Wyswietl_Click;
        }

        private void Usun_Click(object sender, RoutedEventArgs e)
        {
            usuwanie();
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


        private void usuwanie()

        {
            string danePolaczenia = "server=localhost;user=root;password='';database=4pb";
            MySqlConnection polaczenie = new MySqlConnection(danePolaczenia);
            // pobieranie danych
            try
            {
                polaczenie.Open();
                int id1 = int.Parse(id.Text.Trim());
                string kwerenda = $@"
    DELETE FROM uczniowie WHERE uczniowie.id = {id1}";

                //bez @
                // string kwerenda = $"DELETE FROM uczniowie WHERE uczniowie.id = { id1}
                //"
                // $"VALUES ('{nazwisko1}', '{imie1}', {klasa1}, {wychowawca1}, {wplata1})";

                //tworzymy obiekt połaczenia do konstruktora przekazujemy kwerende i połaczenie
                MySqlCommand cmd = new MySqlCommand(kwerenda, polaczenie);
                // 🔥 Wykonanie zapytania
                int wynik = cmd.ExecuteNonQuery();

                if (wynik > 0)
                    MessageBox.Show("Uczeń został usunięty.");
                else
                    MessageBox.Show("Nie udało się usunąć ucznia.");


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

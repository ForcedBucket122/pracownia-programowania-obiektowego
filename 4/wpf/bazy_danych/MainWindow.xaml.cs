using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace bazy_danych
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            Dodawanie dodawanie = new Dodawanie();
            dodawanie.ShowDialog();
        }

        private void Wyswietl_Click(object sender, RoutedEventArgs e)
        {
            Wyswietlanie wyswietlanie = new Wyswietlanie();
            wyswietlanie.ShowDialog();
        }

        private void Usun_Click(object sender, RoutedEventArgs e)
        {
            Usuwanie usuwanie = new Usuwanie();
            usuwanie.ShowDialog();
        }

        private void Wyszukaj_Click(object sender, RoutedEventArgs e)
        {
            Wyszukiwanie wyszukiwanie = new Wyszukiwanie();
            wyszukiwanie.ShowDialog();
        }
    }
}
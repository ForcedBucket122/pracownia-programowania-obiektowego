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

namespace WpfApp2
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

        private void LosujLiczby()
        {
            Random random = new Random();
            int l1 = random.Next(11);
            int l2 = random.Next(11);
            liczba1.Content = l1;
            liczba2.Content = l2;
        }

        private void losuj_Click(object sender, RoutedEventArgs e)
        {
            LosujLiczby();
        }

        private void sprawdz_Click(object sender, RoutedEventArgs e)
        {
            int l1 = int.Parse(liczba1.Content.ToString());
            int l2 = int.Parse(liczba2.Content.ToString());
            int w;

            if (int.TryParse(wynik.Text, out w))
            {
                if (l1 * l2 == w)
                {
                    tekst.Text = "Dobrze!";
                    zdjecie.Source = new BitmapImage(new Uri("/grafika/dobrze.png", UriKind.Relative));
                    LosujLiczby();
                    wynik.Text = "";
                }
                else
                {
                    tekst.Text = "Spróbuj jeszcze raz!";
                    zdjecie.Source = new BitmapImage(new Uri("/grafika/zle.png", UriKind.Relative));
                    wynik.Text = "";
                }
            }
            else
            {
                tekst.Text = "Wpisz poprawną liczbę.";
            }
        }


    }
}
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

namespace calc_combobox
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                double a, b;
                if (!double.TryParse(liczba1.Text, out a) || !double.TryParse(liczba2.Text, out b))
                {
                    wynik.Text = "Wprowadź poprawne liczby.";
                    return;
                }

                string operacja = ((ComboBoxItem)dzialanie.SelectedItem).Content.ToString();
                double rezultat = 0;
                bool poprawne = true;

                switch (operacja)
                {
                    case "+":
                        rezultat = a + b;
                        break;
                    case "-":
                        rezultat = a - b;
                        break;
                    case "*":
                        rezultat = a * b;
                        break;
                    case "/":
                        if (b == 0)
                        {
                            wynik.Text = "Nie dziel przez zero cholero";
                            poprawne = false;
                        }
                        else
                        {
                            rezultat = a / b;
                        }
                        break;
                }

                if (poprawne)
                    wynik.Text = $"Wynik: {rezultat}";
            }
        }
    }
}
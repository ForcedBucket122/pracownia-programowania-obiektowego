using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private int liczba1 = 0, liczba2 = 0;
        private string operacja = "?";

        public MainWindow()
        {
            InitializeComponent();
            LabelLiczba1.Content = liczba1;
            LabelLiczba2.Content = liczba2;
            LabelOperacja.Content = operacja;
            CreateDynamicButtons();
        }

        private void CreateDynamicButtons()
        {
            Button btnSubtract = new Button { Content = "-", Width = 50, FontSize = 16, Margin = new Thickness(2) };
            btnSubtract.Click += ButtonOdejmij_Click;

            Button btnDivide = new Button { Content = "/", Width = 50, FontSize = 16, Margin = new Thickness(2) };
            btnDivide.Click += ButtonDziel_Click;

            StackPanelOperacje.Children.Add(btnSubtract);
            StackPanelOperacje.Children.Add(btnDivide);
        }

        private void ButtonLosuj_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            liczba1 = random.Next(1, 11);
            liczba2 = random.Next(1, 11);

            LabelLiczba1.Content = liczba1;
            LabelLiczba2.Content = liczba2;
            LabelOperacja.Content = operacja;
            TextBoxWynik.Text = "";
        }

        private void ButtonDodaj_Click(object sender, RoutedEventArgs e) { operacja = "+"; LabelOperacja.Content = operacja; }
        private void ButtonMnoz_Click(object sender, RoutedEventArgs e) { operacja = "*"; LabelOperacja.Content = operacja; }
        private void ButtonOdejmij_Click(object sender, RoutedEventArgs e) { operacja = "-"; LabelOperacja.Content = operacja; }
        private void ButtonDziel_Click(object sender, RoutedEventArgs e) { operacja = "/"; LabelOperacja.Content = operacja; }

        private void ButtonSprawdz_Click(object sender, RoutedEventArgs e)
        {
            if (operacja == "?")
            {
                MessageBox.Show("Wybierz operację!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!double.TryParse(TextBoxWynik.Text, out double userResult))
            {
                MessageBox.Show("Proszę wpisać poprawną liczbę.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            double poprawnyWynik = 0;

            switch (operacja)
            {
                case "+": poprawnyWynik = liczba1 + liczba2; break;
                case "-": poprawnyWynik = liczba1 - liczba2; break;
                case "*": poprawnyWynik = liczba1 * liczba2; break;
                case "/":
                    if (liczba2 != 0)
                        poprawnyWynik = (double)liczba1 / liczba2;
                    else
                    {
                        MessageBox.Show("Nie można dzielić przez zero!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    break;
            }

            if (Math.Abs(userResult - poprawnyWynik) < 0.0001)
            {
                MessageBox.Show("Dobrze!", "Wynik", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Źle!", "Wynik", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

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

namespace ciagiliczbowe
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

        private void OpenArithmetic(object sender, RoutedEventArgs e)
        {
            new arytmetyczny().Show();
        }

        private void OpenGeometric(object sender, RoutedEventArgs e)
        {
            new geometryczny().Show();
        }

        private void OpenFibonacci(object sender, RoutedEventArgs e)
        {
            new fibonacci().Show();
        }

    }
}
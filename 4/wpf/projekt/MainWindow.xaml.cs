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

namespace projekt
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

        private void Left_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Top_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Bottom_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(doh, Canvas.GetTop((doh) + 10);
        }
    }
}
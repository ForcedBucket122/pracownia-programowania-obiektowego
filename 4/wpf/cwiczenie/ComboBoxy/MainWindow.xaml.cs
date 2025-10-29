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

namespace ComboBoxy
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            var kolor = kolory.SelectedIndex;

            switch (kolor)
            {
                case 0:
                    MessageBox.Show("Wybrałeś ");
                    break;

                case 1:
                    MessageBox.Show("Wybrałeś ");
                    break;

                case 2:
                    MessageBox.Show("Wybrałeś ");
                    break;
            }
        }
    }
}
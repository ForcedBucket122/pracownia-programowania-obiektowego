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

namespace lista_rozwijana
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

        private void kolor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index_kolor = kolor.SelectedIndex;
            switch (index_kolor)
            {
                case 0:
                    this.Background = Brushes.Yellow;
                    break;
                case 1:
                    this.Background = Brushes.Red;
                    break;
                case 2:
                    this.Background = Brushes.Blue;
                    break;
                case 3:
                    this.Background = Brushes.Green;
                    break;
            }
        }

        private void zwierze_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox zwierzyniec = (ComboBox)sender;
            ComboBoxItem zwierze = zwierzeta.SelectedItem as ComboBoxItem;

            //MessageBox.Show(zwierze.Content.ToString());
            String str = zwierze.Content.ToString();
            BitmapImage bitmapImage = new BitmapImage();
            String sciezka = "D:\\4pb\\4\\wpf\\lista rozwijana\\zdjecia\\";
            bitmapImage.BeginInit();
            switch (str)
            {
                case "lew":
                    //zdjecie.Source = new BitmapImage(new Uri("zdjecia/lew.jpg",UriKind.Relative));
                    bitmapImage.UriSource = new Uri("D:\\4pb\\4\\wpf\\lista rozwijana\\zdjecia\\lew.jpg");
                    break;
                case "żółw":
                    bitmapImage.UriSource = new Uri("D:\\4pb\\4\\wpf\\lista rozwijana\\zdjecia\\zolw.jpg");
                    break;
                case "słoń":
                    bitmapImage.UriSource = new Uri("D:\\4pb\\4\\wpf\\lista rozwijana\\zdjecia\\slon.jpg");
                    break;
                case "lampart":
                    bitmapImage.UriSource = new Uri("D:\\4pb\\4\\wpf\\lista rozwijana\\zdjecia\\lampart.jpg");
                    break;

            }
            bitmapImage.EndInit();
            if (zdjecie != null)
                zdjecie.Source = bitmapImage;
        }
    }
}
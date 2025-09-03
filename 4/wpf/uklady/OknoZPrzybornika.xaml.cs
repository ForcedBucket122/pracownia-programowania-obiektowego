using System;
using System.Collections.Generic;
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

namespace uklady
{
    /// <summary>
    /// Logika interakcji dla klasy OknoZPrzybornika.xaml
    /// </summary>
    public partial class OknoZPrzybornika : Window
    {
        public OknoZPrzybornika()
        {
            InitializeComponent();
        }

        private void buton_click(object sender, RoutedEventArgs e)
        {
            buton.Background = Brushes.Gray;
            buton.Foreground = Brushes.Red;
        }
    }
}

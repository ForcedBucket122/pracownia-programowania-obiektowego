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
using CiagLib1;

namespace ciagiliczbowe
{
    /// <summary>
    /// Logika interakcji dla klasy geometryczny.xaml
    /// </summary>
    public partial class geometryczny : Window
    {
        public geometryczny()
        {
            InitializeComponent();
            
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            try
            {
                double pierwszy, iloraz;
                int n;
                pierwszy = double.Parse(FirstTermBox.Text);
                iloraz = double.Parse(RatioBox.Text);
                n = int.Parse(IndexBox.Text);
                if (n < 0)
                {
                    MessageBox.Show("Wyraz n nie moze byc ujemny");
                }
                else
                {
                    ResultText.Text = Ciagi.Geometryczny(pierwszy, iloraz, n).ToString();
                }
            }
            catch (FormatException ex)
            {
                ResultText.Text = "Błędny format";
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.Message;
            }
        }
    }
}

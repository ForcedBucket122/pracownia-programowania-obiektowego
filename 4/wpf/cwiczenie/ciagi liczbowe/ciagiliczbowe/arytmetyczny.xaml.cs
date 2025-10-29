using CiagLib1;
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

namespace ciagiliczbowe
{
    /// <summary>
    /// Logika interakcji dla klasy arytmetyczny.xaml
    /// </summary>
    public partial class arytmetyczny : Window
    {
        public arytmetyczny()
        {
            InitializeComponent();
            
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            try
            {


                double pierwszy, roznica;
                int n;
                pierwszy = double.Parse(FirstTermBox.Text);
                roznica = double.Parse(DifferenceBox.Text);
                n = int.Parse(IndexBox.Text);
                if (n < 0)
                {
                    MessageBox.Show("Wyraz n nie moze byc ujemny");
                }
                else
                {
                    ResultText.Text = Ciagi.Arytmetyczny(pierwszy, roznica, n).ToString();
                }
            }catch(FormatException ex)
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

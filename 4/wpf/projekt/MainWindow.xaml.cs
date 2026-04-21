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

        bool przeciaganie = false;
        Point pozycjaKursoraNaCanvasie, pozycjaKursoraNaObrazku;

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(doh, Canvas.GetLeft(doh) - 10);
        }

        private void Top_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetTop(doh, Canvas.GetTop(doh) - 10);
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(doh , Canvas.GetLeft(doh)+10);
        }

        private void Bottom_Click(object sender, RoutedEventArgs e)
        {
           Canvas.SetTop(doh, Canvas.GetTop(doh)+10);
        }

        public void MouseUp(object sender, MouseButtonEventArgs e)
        {
            przeciaganie = false;
            pozycjaKursoraNaObrazku=e.GetPosition(doh);
            doh.Cursor = Cursors.Hand;
        }

        private void doh_MouseDown(object sender, MouseButtonEventArgs e)
        {
            przeciaganie = true;
            pozycjaKursoraNaObrazku = e.GetPosition(doh);
            doh.Cursor = Cursors.Arrow;
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if(przeciaganie)
            {
                pozycjaKursoraNaCanvasie = e.GetPosition(canvas);

                Canvas.SetLeft(doh, pozycjaKursoraNaCanvasie.X - pozycjaKursoraNaObrazku.X);
                Canvas.SetTop(doh, pozycjaKursoraNaCanvasie.Y - pozycjaKursoraNaObrazku.Y);

                okno.Title = pozycjaKursoraNaCanvasie.X.ToString()+", "+ pozycjaKursoraNaCanvasie.Y.ToString();
            }

        }
    }
}
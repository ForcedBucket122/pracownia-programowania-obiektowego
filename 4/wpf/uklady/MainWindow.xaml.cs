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

namespace uklady
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
            if (e.Source == buttonStackPanel)
            {
                StackPanel stackPanel = new StackPanel();
                stackPanel.ShowDialog();

            }else if(e.Source == buttonWrapPanel)
            {
                WrapPanel wrapPanel = new WrapPanel();
                wrapPanel.Show();
            }else if(e.Source == buttonGrid)
            {
                Grid grid = new Grid();
                grid.ShowDialog();
            }else if (e.Source == buttonUniformGrid)
            {
                uniformGrid uniformGrid = new uniformGrid();
                uniformGrid.ShowDialog();
            }else if( e.Source == buttonDockPanel)
            {
                DockPanel dockPanel = new DockPanel();
                dockPanel.ShowDialog();
            }else if(e.Source == buttonCanvas)
            {
                canvas canvas = new canvas();
                canvas.ShowDialog();
            }else if (e.Source == buttonPrzybornik)
            {
                OknoZPrzybornika oknoZPrzybornika = new OknoZPrzybornika();
                oknoZPrzybornika.ShowDialog();
            }
        }


        
    }
}
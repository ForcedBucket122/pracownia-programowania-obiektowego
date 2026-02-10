using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace ukladanka
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        Stopwatch stopwatch;

        private const int SIZE = 4;
        private Image[,] board = new Image[SIZE, SIZE];
        private WrapPanel wrapPanel;

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += Timer_Tick;

            stopwatch = new Stopwatch();

            // WrapPanel z XAML
            wrapPanel = (WrapPanel)this.Content;

            // Wypełniamy tablicę obrazkami
            int index = 0;
            foreach (var child in wrapPanel.Children.OfType<Image>())
            {
                int row = index / SIZE;
                int col = index % SIZE;
                board[row, col] = child;

                child.MouseLeftButtonUp += Image_Click;
                index++;
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            var elapsed = stopwatch.Elapsed;
            czas.Content = elapsed.ToString(@"hh\:mm\:ss\:fff");
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            timer.Start();

            Shuffle();
            Redraw();
        }

        private void Shuffle()
        {
            Random rnd = new Random();

            // znajdź puste pole
            int emptyRow = -1, emptyCol = -1;
            for (int r = 0; r < SIZE; r++)
            {
                for (int c = 0; c < SIZE; c++)
                {
                    if (board[r, c].Source == null)
                    {
                        emptyRow = r;
                        emptyCol = c;
                        break;
                    }
                }
                if (emptyRow != -1) break;
            }

            // wykonaj np. 200 losowych przesunięć pustego pola
            for (int i = 0; i < 1; i++)
            {
                var moves = new (int r, int c)[]
                {
            (emptyRow - 1, emptyCol),
            (emptyRow + 1, emptyCol),
            (emptyRow, emptyCol - 1),
            (emptyRow, emptyCol + 1)
                };

                // wybierz tylko ruchy w granicach planszy
                var validMoves = moves.Where(m => m.r >= 0 && m.r < SIZE && m.c >= 0 && m.c < SIZE).ToList();

                // wybierz losowego sąsiada
                var move = validMoves[rnd.Next(validMoves.Count)];

                // zamień miejscami z pustym
                var tmp = board[move.r, move.c];
                board[move.r, move.c] = board[emptyRow, emptyCol];
                board[emptyRow, emptyCol] = tmp;

                // aktualizuj pozycję pustego pola
                emptyRow = move.r;
                emptyCol = move.c;
            }
        }


        private bool IsSolvable(List<Image> images)
        {
            int[] flat = new int[SIZE * SIZE];
            int emptyIndex = -1;

            for (int i = 0; i < images.Count; i++)
            {
                var src = images[i].Source?.ToString();
                if (src == null)
                {
                    flat[i] = 0;
                    emptyIndex = i;
                }
                else
                {
                    // zakładamy nazwy sshrek-x-y.png → numer = y * SIZE + x + 1
                    var parts = src.Split('-', '.', '/');
                    int x = int.Parse(parts[^3]);
                    int y = int.Parse(parts[^2]);
                    flat[i] = y * SIZE + x + 1;
                }
            }

            int inversions = 0;
            for (int i = 0; i < flat.Length; i++)
            {
                for (int j = i + 1; j < flat.Length; j++)
                {
                    if (flat[i] > 0 && flat[j] > 0 && flat[i] > flat[j])
                        inversions++;
                }
            }

            int emptyRowFromBottom = SIZE - (emptyIndex / SIZE);
            return (inversions + emptyRowFromBottom) % 2 == 0;
        }


        private void Redraw()
        {
            wrapPanel.Children.Clear();
            wrapPanel.Children.Add(start);
            wrapPanel.Children.Add(czas);

            for (int r = 0; r < SIZE; r++)
            {
                for (int c = 0; c < SIZE; c++)
                {
                    wrapPanel.Children.Add(board[r, c]);
                }
            }
        }

        private void Image_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Image clicked = (Image)sender;

            int row = -1, col = -1;
            for (int r = 0; r < SIZE; r++)
            {
                for (int c = 0; c < SIZE; c++)
                {
                    if (board[r, c] == clicked)
                    {
                        row = r; col = c;
                        break;
                    }
                }
            }

            TryMove(row, col, row - 1, col);
            TryMove(row, col, row + 1, col);
            TryMove(row, col, row, col - 1);
            TryMove(row, col, row, col + 1);

            // po każdym ruchu sprawdzamy czy układanka jest ułożona
            if (IsSolved())
            {
                stopwatch.Stop();
                timer.Stop();
                MessageBox.Show("Gratulacje!");
            }
        }

        private void TryMove(int r1, int c1, int r2, int c2)
        {
            if (r2 < 0 || r2 >= SIZE || c2 < 0 || c2 >= SIZE) return;

            if (board[r2, c2].Source == null) // puste miejsce
            {
                var tmp = board[r1, c1];
                board[r1, c1] = board[r2, c2];
                board[r2, c2] = tmp;
                Redraw();
            }
        }

        private bool IsSolved()
        {
            // sprawdzamy czy obrazki są w kolejności
            int index = 0;
            foreach (var child in wrapPanel.Children.OfType<Image>())
            {
                // nazwy plików np. sshrek-0-0.png, sshrek-1-0.png itd.
                string expected = $"/grafika/sshrek-{index % SIZE}-{index / SIZE}.png";
                if (child.Source != null && child.Source.ToString().Contains(expected) == false)
                    return false;
                index++;
            }
            return true;
        }
    }
}

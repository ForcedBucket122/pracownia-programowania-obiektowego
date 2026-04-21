using System;
using System.Collections.Generic;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Zadanie
{
    public partial class MainWindow : Window
    {
        // Aktualnie przeciągany obrazek
        private Image _draggedAnimal;

        // Czy trwa przeciąganie
        private bool _isDragging;

        // Pozycja kursora względem obrazka
        private Point _mouseOffset;

        // Oryginalne pozycje startowe zwierząt
        private Dictionary<Image, Point> _startPositions = new Dictionary<Image, Point>();

        // Zbiór poprawnie dopasowanych zwierząt
        private HashSet<Image> _matchedAnimals = new HashSet<Image>();

        // Całkowita liczba zwierząt
        private int _totalAnimals = 6;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        /// <summary>
        /// Po załadowaniu okna zapisuje oryginalne pozycje wszystkich zwierząt.
        /// </summary>
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            SaveStartPositions();
        }

        /// <summary>
        /// Zapisuje pozycje startowe wszystkich obrazków zwierząt.
        /// </summary>
        private void SaveStartPositions()
        {
            _startPositions.Clear();

            foreach (UIElement element in MainCanvas.Children)
            {
                if (element is Image img && img.Tag != null)
                {
                    double left = Canvas.GetLeft(img);
                    double top = Canvas.GetTop(img);
                    _startPositions[img] = new Point(left, top);
                }
            }
        }

        /// <summary>
        /// Rozpoczyna przeciąganie zwierzęcia.
        /// </summary>
        private void Animal_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image animal = sender as Image;
            if (animal == null) return;

            // Jeśli zwierzę już dopasowane, nie pozwól go ruszać
            if (_matchedAnimals.Contains(animal)) return;

            _draggedAnimal = animal;
            _isDragging = true;
            _mouseOffset = e.GetPosition(animal);

            animal.CaptureMouse();
        }

        /// <summary>
        /// Przesuwa zwierzę podczas przeciągania.
        /// </summary>
        private void Animal_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDragging || _draggedAnimal == null) return;

            Point mousePos = e.GetPosition(MainCanvas);

            double newLeft = mousePos.X - _mouseOffset.X;
            double newTop = mousePos.Y - _mouseOffset.Y;

            Canvas.SetLeft(_draggedAnimal, newLeft);
            Canvas.SetTop(_draggedAnimal, newTop);
        }

        /// <summary>
        /// Kończy przeciąganie i sprawdza dopasowanie.
        /// </summary>
        private void Animal_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (!_isDragging || _draggedAnimal == null) return;

            _draggedAnimal.ReleaseMouseCapture();
            _isDragging = false;

            CheckDropResult(_draggedAnimal);
            _draggedAnimal = null;
        }

        /// <summary>
        /// Sprawdza, czy zwierzę zostało upuszczone na właściwe pudełko.
        /// </summary>
        private void CheckDropResult(Image animal)
        {
            string animalTag = animal.Tag?.ToString();
            if (string.IsNullOrEmpty(animalTag)) return;

            // Prostokąt zwierzęcia
            Rect animalRect = new Rect(
                Canvas.GetLeft(animal),
                Canvas.GetTop(animal),
                animal.Width,
                animal.Height);

            // Szukamy pudełka, na które upuszczono zwierzę
            foreach (UIElement element in MainCanvas.Children)
            {
                if (element is Border box && box.Tag != null)
                {
                    Rect boxRect = new Rect(
                        Canvas.GetLeft(box),
                        Canvas.GetTop(box),
                        box.Width,
                        box.Height);

                    // Sprawdzamy przecięcie
                    if (animalRect.IntersectsWith(boxRect))
                    {
                        string boxTag = box.Tag.ToString();

                        if (animalTag == boxTag)
                        {
                            // Poprawne dopasowanie
                            HandleCorrectMatch(animal, box);
                        }
                        else
                        {
                            // Błędne dopasowanie
                            HandleWrongMatch(animal);
                        }
                        return;
                    }
                }
            }

            // Upuszczono poza pudełkami - wróć na miejsce
            ReturnToStart(animal);
        }

        /// <summary>
        /// Obsługuje poprawne dopasowanie zwierzęcia.
        /// </summary>
        private void HandleCorrectMatch(Image animal, Border box)
        {
            // Ustaw zwierzę wycentrowane NA pudełku
            double centerX = Canvas.GetLeft(box) + (box.Width - animal.Width) / 2;
            double centerY = Canvas.GetTop(box) + (box.Height - animal.Height) / 2;

            Canvas.SetLeft(animal, centerX);
            Canvas.SetTop(animal, centerY);

            // Podnieś zwierzę na wierzch (nad pudełko)
            Panel.SetZIndex(animal, 10);

            // Dodaj do zbioru dopasowanych
            _matchedAnimals.Add(animal);

            // Odtwórz dźwięk zwierzęcia
            if (animal.Tag.ToString() != " " && animal.Tag.ToString() != null)
            {
                PlayAnimalSound(animal.Tag.ToString());
            }

            // Pokaż komunikat
            //MessageBox.Show("Dobrze!", "Brawo!", MessageBoxButton.OK, MessageBoxImage.Information);

            // Sprawdź, czy wszystkie dopasowane
            CheckGameComplete();
        }

        /// <summary>
        /// Obsługuje błędne dopasowanie.
        /// </summary>
        private void HandleWrongMatch(Image animal)
        {
            MessageBox.Show("Źle!", "Spróbuj ponownie", MessageBoxButton.OK, MessageBoxImage.Warning);
            ReturnToStart(animal);
        }

        /// <summary>
        /// Zwraca zwierzę na pozycję startową.
        /// </summary>
        private void ReturnToStart(Image animal)
        {
            if (_startPositions.TryGetValue(animal, out Point startPos))
            {
                Canvas.SetLeft(animal, startPos.X);
                Canvas.SetTop(animal, startPos.Y);
            }
        }

        /// <summary>
        /// Sprawdza, czy gra została ukończona.
        /// </summary>
        private void CheckGameComplete()
        {
            if (_matchedAnimals.Count >= _totalAnimals)
            {
                MessageBox.Show("Gratulacje! Dopasowałeś wszystkie zwierzęta!",
                    "Wygrana!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                ResetGame();
            }
        }

        /// <summary>
        /// Resetuje grę - wszystkie zwierzęta wracają na pozycje startowe.
        /// </summary>
        private void ResetGame()
        {
            _matchedAnimals.Clear();

            foreach (var kvp in _startPositions)
            {
                Image animal = kvp.Key;
                Point startPos = kvp.Value;

                Canvas.SetLeft(animal, startPos.X);
                Canvas.SetTop(animal, startPos.Y);
            }
        }

        private void PlayAnimalSound(string animalName)
        {
            try
            {
                string soundFile;

                if (animalName == "kaczka")
                    soundFile = "kaczka.wav";
                else if (animalName == "kon")
                    soundFile = "kon.wav";
                else if (animalName == "kot")
                    soundFile = "kot.wav";
                else if (animalName == "krowa")
                    soundFile = "krowa.wav";
                else if (animalName == "owca")
                    soundFile = "owca.wav";
                else if (animalName == "pies")
                    soundFile = "pies.wav";
                else
                    return;

                string soundPath = System.IO.Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "dzwiek", soundFile);

                if (System.IO.File.Exists(soundPath))
                {
                    // Użyj MediaPlayer zamiast SoundPlayer - obsługuje więcej formatów
                    var mediaPlayer = new System.Windows.Media.MediaPlayer();
                    mediaPlayer.Open(new Uri(soundPath, UriKind.Absolute));
                    mediaPlayer.Play();
                }
            }
            catch (Exception)
            {
                // Dźwięk niedostępny - ignorujemy błąd
            }
        }
    }
}

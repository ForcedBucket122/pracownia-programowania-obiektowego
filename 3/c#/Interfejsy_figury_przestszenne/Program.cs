namespace Interfejsy_figury_przestszenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FiguryPrzestrzenne> figury = new List<FiguryPrzestrzenne>
            {
                new Kula(1),
                new Prostopadloscian(1, 2, 3),
                new Walec(1, 2),
                new Stozek(1, 2)
            };

            while (true)
            {
                Console.WriteLine("Wybierz figurę, dla której chcesz wyświetlić dane:");
                for (int i = 0; i < figury.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {figury[i].Typ()}");
                }
                Console.WriteLine("0. Wyjście");

                Console.Write("\nTwój wybór: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int wybor))
                {
                    if (wybor == 0)
                    {
                        Console.WriteLine("Dziękujemy za korzystanie z programu!");
                        break;
                    }

                    if (wybor >= 1 && wybor <= figury.Count)
                    {
                        FiguryPrzestrzenne figura = figury[wybor - 1];
                        Console.WriteLine($"Wybrana figura: {figura.Typ()}");
                        Console.WriteLine($"Objętość: {figura.Objetosc():F2}");
                        Console.WriteLine($"Pole powierzchni: {figura.PolePowierzchni():F2}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("\nNieprawidłowy wybór. Spróbuj ponownie.");
                    }
                }
                else
                {
                    Console.WriteLine("\nNieprawidłowe dane wejściowe. Spróbuj ponownie.");
                }
            }
        }
    }
}

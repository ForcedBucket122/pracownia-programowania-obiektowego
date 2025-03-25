namespace figury_plaskie_polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<figura> figury = new List<figura>();
            bool dzialaj = true;

            while (dzialaj)
            {
                Console.WriteLine("Wybierz opcję:");
                Console.WriteLine("1. Dodaj prostokąt");
                Console.WriteLine("2. Dodaj koło");
                Console.WriteLine("3. Dodaj trójkąt");
                Console.WriteLine("4. Wyświetl wszystkie figury");
                Console.WriteLine("5. Zakończ program");

                string wybor = Console.ReadLine();

                try
                {
                    switch (wybor)
                    {
                        case "1":
                            Console.WriteLine("Podaj długość prostokąta:");
                            double dlugosc = double.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj szerokość prostokąta:");
                            double szerokosc = double.Parse(Console.ReadLine());
                            figury.Add(new prostokat(dlugosc, szerokosc));
                            Console.WriteLine("Dodano prostokąt.\n");
                            break;

                        case "2":
                            Console.WriteLine("Podaj promień koła:");
                            double promien = double.Parse(Console.ReadLine());
                            figury.Add(new kolo(promien));
                            Console.WriteLine("Dodano koło.\n");
                            break;

                        case "3":
                            Console.WriteLine("Podaj długość boku A trójkąta:");
                            double bokA = double.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj długość boku B trójkąta:");
                            double bokB = double.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj długość boku C trójkąta:");
                            double bokC = double.Parse(Console.ReadLine());

                            trojkat nowyTrojkat = new trojkat(bokA, bokB, bokC);
                            if (!nowyTrojkat.czyIstnieje())
                            {
                                Console.WriteLine("Trójkąt o podanych bokach nie istnieje.\n");
                            }
                            else
                            {
                                figury.Add(nowyTrojkat);
                                Console.WriteLine("Dodano trójkąt.\n");
                            }
                            break;

                        case "4":
                            if (figury.Count == 0)
                            {
                                Console.WriteLine("Brak figur do wyświetlenia.\n");
                            }
                            else
                            {
                                foreach (var figura in figury)
                                {
                                    Console.WriteLine($"Typ: {figura.typ}");
                                    Console.WriteLine($"Pole: {figura.pole():F2}");
                                    Console.WriteLine($"Obwód: {figura.obwod():F2}\n");
                                }
                            }
                            break;

                        case "5":
                            dzialaj = false;
                            Console.WriteLine("Zakończono program.");
                            break;

                        default:
                            Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.\n");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił błąd: {ex.Message}. Spróbuj ponownie.\n");
                }
            }
        }
    }
}

using metody_statyczne;
using System;

namespace metody_statyczne
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWybierz opcję: ");
                Console.WriteLine("1. Oblicz silnię");
                Console.WriteLine("2. Oblicz potęgę");
                Console.WriteLine("3. Sprawdź, czy liczba jest pierwsza");
                Console.WriteLine("4. Sprawdź, czy liczba jest doskonała");
                Console.WriteLine("5. Oblicz NWD");
                Console.WriteLine("0. Wyjście z programu");

                try
                {
                    byte opcja = Convert.ToByte(Console.ReadLine());

                    switch (opcja)
                    {
                        case 1:
                            Console.Write("Podaj liczbę naturalną: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Silnia wynosi: " + Matematyka.Silnia(n));
                            break;
                        case 2:
                            Console.Write("Podaj podstawę: ");
                            double podstawa = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Podaj wykładnik: ");
                            int wykladnik = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Wynik potęgowania: " + Matematyka.Potega(podstawa, wykladnik));
                            break;
                        case 3:
                            Console.Write("Podaj liczbę: ");
                            int liczba = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Czy liczba jest pierwsza? " + Matematyka.CzyPierwsza(liczba));
                            break;
                        case 4:
                            Console.Write("Podaj liczbę naturalną: ");
                            int liczbaDoskonala = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Czy liczba jest doskonała? " + Matematyka.CzyDoskonala(liczbaDoskonala));
                            break;
                        case 5:
                            Console.Write("Podaj pierwszą liczbę naturalną: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Podaj drugą liczbę naturalną: ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("NWD wynosi: " + Matematyka.NWD(a, b));
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Podaj liczbę od 0 do 5.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Niewłaściwy format! Podaj liczbę całkowitą.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

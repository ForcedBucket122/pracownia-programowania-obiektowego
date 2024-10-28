namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double l1;
                double l2;
                double wynik;
                byte opcja;

                
                Console.WriteLine("\nWybierz operację: ");
                Console.WriteLine("1.Dodawanie");
                Console.WriteLine("2.Odejmowanie");
                Console.WriteLine("3.Dzielenie");
                Console.WriteLine("4.Mnożenie");
                Console.WriteLine("5.Potęgowanie");
                Console.WriteLine("6.Pierwiastkowanie");
                Console.WriteLine("7.Opuść program");
                
                Console.WriteLine();

                try
                {
                    opcja = Convert.ToByte(Console.ReadLine());
                    switch (opcja)
                    {
                        case 1:
                            Console.Write("Podaj pierwszy składnik: ");
                            l1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Podaj drugi składnik: ");
                            l2 = Convert.ToDouble(Console.ReadLine());
                            wynik = l1 + l2;

                            Console.WriteLine("Suma wynosi: " + wynik);
                            break;
                        case 2:
                            Console.Write("Podaj odjemną: ");
                            l1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Podaj odjemnik: ");
                            l2 = Convert.ToDouble(Console.ReadLine());
                            wynik = l1 - l2;
                            Console.WriteLine("Róznica wynosi: " + wynik);
                            break;
                        case 3:
                            Console.Write("Podaj dzielną: ");
                            l1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Podaj dzielnik: ");
                            l2 = Convert.ToDouble(Console.ReadLine());
                            wynik = l1 / l2;

                            Console.WriteLine("Iloraz wynosi: " + wynik);
                            break;
                        case 4:
                            Console.Write("Podaj pierwszy czynnik: ");
                            l1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Podaj drugi czynnik: ");
                            l2 = Convert.ToDouble(Console.ReadLine());
                            wynik = l1 * l2;

                            Console.WriteLine("Iloczyn wynosi: " + wynik);
                            break;
                        case 5:
                            Console.Write("Podaj podstawę potęgi: ");
                            l1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Podaj wykładnik: ");
                            l2 = Convert.ToDouble(Console.ReadLine());
                            wynik = Math.Pow(l1, l2);

                            Console.WriteLine("Potęga wynosi: " + wynik);
                            break;
                        case 6:
                            Console.Write("Podaj podstawę pierwiastka: ");
                            l1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Podaj wykładnik: ");
                            l2 = Convert.ToDouble(Console.ReadLine());
                            if (l1 %2==0)
                            {
                                Console.WriteLine("Nie może to być liczba ujemna!");
                            }
                            else if(l1==0){
                                Console.WriteLine("Nie może to zero!");
                            }
                            else
                            {
                                
                                wynik = Math.Pow(l1, 1.0 / l2);
                                Console.WriteLine("Wynik to: " + wynik);
                            }
                            break;
                        case 7:
                            System.Environment.Exit(0);
                            break;
                        default: Console.WriteLine("Podaj liczbe od 1 do 7");
                            break;
                    }
                }
                catch (FormatException) { Console.WriteLine("Niewłaściwy format!"); }
                catch (DivideByZeroException) { Console.WriteLine("Nie dziel przez zero cholero!"); }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

            }
            
        }
    }
}

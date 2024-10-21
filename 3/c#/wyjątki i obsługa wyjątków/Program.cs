namespace wyjątki_i_obsługa_wyjątków
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                Console.WriteLine("Wyjątki - obsługa wyjątków");
                Console.Write("Podaj liczbę a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"a={a}");

                Console.Write("Podaj liczbę b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"b={b}");
                Console.WriteLine($"a/b={a/b}");
            }
            catch(DivideByZeroException ex) 
            {
                Console.WriteLine("Błąd dzielenia przez zero "+ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Błędny format danych " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Przekroczono zakres wartosci " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd" + ex.Message);
            }
        }
    }
}

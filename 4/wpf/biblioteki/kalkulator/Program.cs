using MathLib1;
namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double liczba1, liczba2;
            liczba1 = Pobierz();
            liczba2 = Pobierz();
            Console.WriteLine($"{liczba1}+{liczba2}={Algebra.Suma(liczba1, liczba2)}");
            Console.WriteLine($"{liczba1}-{liczba2}={MathLib1.Algebra.Roznica(liczba1, liczba2)}");
            Console.WriteLine($"{liczba1}*{liczba2}={Algebra1.Iloczyn(liczba1, liczba2)}");
            if (Algebra1.Iloraz(liczba1, liczba2) == 0)
            {
                Console.WriteLine("Nie dziel przez zero cholero!");
                Environment.Exit(67);
            }
            else
            {
                Console.WriteLine($"{liczba1}/{liczba2}={Algebra1.Iloraz(liczba1, liczba2)}");
            }
        }
        static public double Pobierz()
        {
            double a=0;
            try
            {
                Console.WriteLine("Podaj liczbe");
                a = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(67);
            }
            return a;
            
            
        }
    }
}

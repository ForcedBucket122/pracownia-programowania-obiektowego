namespace kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double liczba1, liczba2;

            liczba1 = Pobierz();
            liczba2 = Pobierz();
            Console.WriteLine($"{liczba1}+{liczba2}={MathLib1.Algebra.Suma(liczba1, liczba2)}");
            Console.WriteLine($"{liczba1}-{liczba2}={MathLib1.Algebra.Roznica(liczba1, liczba2)}");
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

namespace rk1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = Convert.ToDouble(Console.ReadLine());
            RK rK = new RK(a, b, c);
            rK.Rozwiazanie();
        }
    }
}

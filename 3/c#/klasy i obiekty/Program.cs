namespace klasy_i_obiekty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mata1 m1 = new Mata1();
            int x = 0;
            int y = 1;
            Console.WriteLine($"{x} + {y} = "+ m1.Suma(x,y));
            Console.WriteLine($"{x} - {y} = " + Mata1.Roznica(x, y));
        }
    }
}

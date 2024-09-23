namespace lekcja1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lekcja 1");
            System.Console.WriteLine("Wprowadzenie");

            int a;
            a= 12;
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());
            Console.WriteLine(int.MaxValue);
            float b = 2.4312423453543565475675f;
            double c = 2.5345347567423412341452356875454239564927842;
            Console.WriteLine(b);
            Console.WriteLine(b.GetType());
            Console.WriteLine(c);
            Console.WriteLine(c.GetType());
            //Console.WriteLine("Wcisnij dowolny klawisz");
            //if (Console.ReadKey().Key==ConsoleKey.Escape) {
            //    Console.WriteLine("wcisnales esc");
            //}
            //do
            //{
            //    Console.WriteLine("Witaj!");
            //    Console.WriteLine("Wcisnij klawisz ESC aby zakonczyc");
            //    if (Console.ReadKey().Key == ConsoleKey.Escape)
            //    {
            //        System.Environment.Exit(0);
            //    }
            //}while (true);
            Console.WriteLine("Wcisnij dowolny klawisz aby zakonczyc");
            Console.ReadKey();
        }
    }
}

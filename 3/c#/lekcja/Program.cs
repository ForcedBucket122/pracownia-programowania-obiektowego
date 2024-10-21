namespace lekcja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World!");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("\tWitaj \n\"tekst\" w\\\\ pogramie");
            Console.WriteLine("Podaj zmienną a");
            String a = Console.ReadLine();
            Console.WriteLine(a);
            Console.WriteLine("Podaj zmienną b");
            int b = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine(b);
            Console.WriteLine("Podaj zmienną c");
            Char c = Convert.ToChar(Console.Read());
            Console.WriteLine((int)c);
            Console.WriteLine("podaj liczbę");
            int s= int.Parse(Console.ReadLine());*/
            Random random = new Random();
            //double los = random.NextDouble();
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(los);
            int color = random.Next(0, 16);
            Console.BackgroundColor = (ConsoleColor)color;
            Console.Clear();
            do
            {
                color = random.Next(0, 16);
                Console.BackgroundColor = (ConsoleColor)color;
                Console.Clear();
                Thread.Sleep(100);
            } while (color!=0);
        }
    }
}

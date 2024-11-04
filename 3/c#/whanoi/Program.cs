namespace whanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę dysków: ");
            int liczbaDyskow;

            while (!int.TryParse(Console.ReadLine(), out liczbaDyskow) || liczbaDyskow <= 0)
            {
                Console.Write("Podaj poprawną liczbę dysków: ");
            }

            WiezaHanoi(liczbaDyskow, 'A', 'C', 'B');
        }

        static void WiezaHanoi(int n, char z, char do_, char pomocniczy)
        {
            if (n == 1)
            {
                Console.WriteLine($"Przenieś dysk 1 z {z} do {do_}");
                return;
            }

            WiezaHanoi(n - 1, z, pomocniczy, do_);
            Console.WriteLine($"Przenieś dysk {n} z {z} do {do_}");
            WiezaHanoi(n - 1, pomocniczy, do_, z);
        }
    }
}
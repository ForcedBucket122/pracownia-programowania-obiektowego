namespace kolekcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tablice\n\n\n\n\n");
            int[] t1 = new int[10];

            for(int i = 0; i < t1.Length; i++)
            {
                t1 [i] = i;
            }
            for(int i = 0;i < t1.Length; i++)
            {
                Console.Write($"{t1[i],4}");
            }
        }
    }
}

namespace forech;

internal class Program
{
    static void Main(string[] args)
    {
        string ala = "Ala ma kota";
        ala.ToCharArray();
        for (int i = 0; i < 10; i++) {
            Console.WriteLine(ala[i]);
        }
        foreach (char x in ala) {
            Console.Write(x);
        }
        for (int i = 0;i <= 100; i++) 
        {
            if(i % 10 != 0)
            {
                continue;
            }
            Console.Write(i+" ");
        }
        int[] tab = new int[] {2,4,6,8};
        foreach (var x in tab)
        {
            Console.Write(x);
        }
    }
}

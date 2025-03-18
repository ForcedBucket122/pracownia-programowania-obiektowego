namespace Klasy_abstrakcyjne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Klasy absrakcyjne");

            Zwierzeta kot = new Kot();
            Zwierzeta pies = new Pies();
            Zwierzeta krowa = new Krowa();

            List<Zwierzeta> list = new List<Zwierzeta>();

            list.Add(kot);
            list.Add(pies);
            list.Add(krowa);
            list.Add(new Kot());
            list.Add(new Pies());
            list.Add(new Krowa());

            foreach (var item in list)
            {
                item.DajGlos();
                item.Pokarm();
                Console.WriteLine("-------");
            }

            Console.ReadKey();
        }
    }
}

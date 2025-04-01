namespace klasy_abstrakcyjne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Zwierzeta> zwierzeta = new List<Zwierzeta>();
            zwierzeta.Add(new Kot());
            zwierzeta.Add(new Pies());
            zwierzeta.Add(new Krowa());
            foreach (var item in zwierzeta)
            {
                item.Typ();
                item.DajGlos();
                item.CzymSieZywie();
                if (item is Pies)
                {
                    ((Pies)item).OPsie();
                }
                Console.WriteLine();
            }
        }
    }
}

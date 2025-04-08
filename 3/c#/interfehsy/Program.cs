namespace interfehsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Zwierze> zwierzes = new List<Zwierze>()
            {
                new Pies(),
                new Kot(),
                new Krowa(),
                new Pies(),
                new Kot(),
                new Krowa()
            };

            foreach(var item in zwierzes)
            {
                Console.WriteLine("\n"+item.Typ());
                item.DajGlos();
                item.Pozywienie();
                item.Pozytek();
                item.OZwierzu();
            }
            
        }
    }
}

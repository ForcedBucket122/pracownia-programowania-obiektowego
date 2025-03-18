namespace polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bez polimorfizmu");
            Kot kot1 = new Kot();

            Zwierze kot2 = new Kot();

            //kot1.DajGlos();
            //kot1.Pozywienie();
            //kot1.Pozytek();


            //((Kot)kot2).DajGlos();
            //((Kot)kot2).Pozywienie();
            //((Kot)kot2).Pozytek();

            List <Zwierze> list = new List <Zwierze>();
            list.Add(kot1);
            list.Add(kot2);
            list.Add(new Kot());
            list.Add(new Pies());
            list.Add(new Pies());
            list.Add(new Pies());
            list.Add(new Krowa());
            list.Add(new Krowa());
            list.Add(new Krowa());

            Console.WriteLine(list.Count());

            //for (int i = 0; i < list.Count; i++) {
            //    list[i].DajGlos();
            //    list[i].Pozywienie();
            //    list[i].Pozytek();
            //}
            foreach (var item in list)
            {
                if (item.GetType()==typeof(Kot))
                {
                    ((Kot)item).DajGlos();
                    ((Kot)item).Pozywienie();
                    ((Kot)item).Pozytek();
                }
                else if (item.GetType() == typeof(Pies))
                {
                    ((Pies)item).DajGlos();
                    ((Pies)item).Pozywienie();
                    ((Pies)item).Pozytek();
                }
                else if (item.GetType() == typeof(Krowa))
                {
                    ((Krowa)item).DajGlos();
                    ((Krowa)item).Pozywienie();
                    ((Krowa)item).Pozytek();
                }

            }
        }
    }
}

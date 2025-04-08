namespace Interfejsy_figury_przestszenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FiguryPrzestrzenne> figury = new List<FiguryPrzestrzenne>
            {
                new Kula(1),
                new Prostopadloscian(1,2,3),
            };
            foreach(var item in figury)
            {
                item.Objetosc();
                item.PolePowierzchni();
            }
        }
    }
}

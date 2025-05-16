using System.Collections;

namespace listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List ArrayList-------------------------]");
            List<string> lista1 = new List<string>();

            List<string> lista2 = new List<string>() { "a", "b", "c" };

            ArrayList lista3 = new ArrayList() { "1", 1, true };

            lista1.Add("1");
            lista1.Add("2");
            Console.WriteLine(lista1.Contains("1"));
            lista1.AddRange(lista2);

            wyswietl(lista1);
        }

        static public void wyswietl(List<string> lista)
        {
            foreach (var item in lista)
            {
                Console.Write(item + ", ");
            }
        }

        static public void wypelnij(List<string> lista, int liczba)
        {
            string imie;
            for (int i = 0; i < liczba; i++)
            {
                Console.WriteLine("Podaj imię:");
                imie = Console.ReadLine();
                lista.Add(imie);
            }
        }

        static public void wypelnij2(List<int> lista, int liczba)
        {
            int num;
            Random rnd = new Random();

            for (int i = 0; i < liczba; i++)
            {
                num = rnd.Next(10);
                lista.Add(num);
            }
        }
    }
}

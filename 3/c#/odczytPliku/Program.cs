using System;
using System.IO;

namespace odczytPliku
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string sciezka = "pliki/test.txt";
                //string pelnaSciezka = Path.GetFullPath(sciezka);
                //Console.WriteLine("Pełna ścieżka: " + pelnaSciezka);


                // Odczyt pierwszych dwóch linii
                //using (StreamReader streamReader = new StreamReader(sciezka))
                //{
                //    Console.WriteLine(streamReader.ReadLine());
                //    Console.WriteLine(streamReader.ReadLine());
                //}

                //Console.WriteLine("Podaj sciezke:");
                //string sciezka2 = Console.ReadLine();

                //// Odczyt całej zawartości z podanej ścieżki
                //using (StreamReader reader = new StreamReader(sciezka2))
                //{
                //    Console.WriteLine(reader.ReadToEnd());
                //}

                // Zapis do pliku
                //Console.WriteLine("Podaj tekst do zapisu:");
                //string tekst = Console.ReadLine();

                //using (StreamWriter writer = new StreamWriter(sciezka))
                //{
                //    writer.WriteLine(tekst);
                //}

                //Console.WriteLine("Zapisano pomyślnie.");
                List<string> list = new List<string>();

            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił błąd: " + e.Message);
            }
        }
    }
}

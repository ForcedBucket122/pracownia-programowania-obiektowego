namespace odczytPliku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sciezka = "pliki/test.txt";
                StreamReader streamReader = new StreamReader(sciezka);
                Console.WriteLine(streamReader.ReadLine());
                Console.WriteLine(streamReader.ReadLine());
                streamReader.Close();
                //Console.WriteLine("Podaj sciezke");
                //string sciezka2 = Console.ReadLine();
                //StreamReader reader = new StreamReader(sciezka2);
                //Console.WriteLine(reader.ReadToEnd());
                
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

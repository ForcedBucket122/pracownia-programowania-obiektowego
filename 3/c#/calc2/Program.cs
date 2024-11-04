namespace calc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcja;
            try
            {
                do
                {
                    Console.WriteLine("1.licz\n0-wyjscie");
                    Console.WriteLine("Wybierz opcje");
                    opcja = Convert.ToInt32(Console.ReadLine());
                    switch (opcja)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            try
                            {
                                Console.WriteLine("Podaj liczbe ");
                                int a = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }
                            try
                            {
                            Console.WriteLine("Podaj liczbe ");
                                int b = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }

                            break;


                    }
                } while (true);
            }catch (Exception ex) { Console.WriteLine("blad "+ex.Message); }
            
        }
    }
}

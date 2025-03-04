namespace TrojkatWUkladzieWspolrzednych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Punkt punktA = new Punkt();
                    Punkt punktB = new Punkt();
                    Punkt punktC = new Punkt();

                    Console.WriteLine("Podaj współrzędną X Punktu A: ");
                    punktA.X = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Podaj współrzędną Y Punktu A: ");
                    punktA.Y = Double.Parse(Console.ReadLine());
                    //-----------------------------------------
                    Console.WriteLine("Podaj współrzędną X Punktu B: ");
                    punktB.X = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Podaj współrzędną Y Punktu B: ");
                    punktB.Y = Double.Parse(Console.ReadLine());
                    //-----------------------------------------
                    Console.WriteLine("Podaj współrzędną X Punktu C: ");
                    punktC.X = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Podaj współrzędną Y Punktu C: ");
                    punktC.Y = Double.Parse(Console.ReadLine());
                    //-----------------------------------------

                    Console.WriteLine($"Trójkąt ma wierzchołki o współrzędnych:\n A:({punktA.X}, {punktA.Y}),\n" +
                        $" B:({punktB.X}, {punktB.Y}), \n" +
                        $" C:({punktC.X}, {punktC.Y}),");

                    Odcinek AB = new Odcinek(punktA, punktB);
                    Odcinek BC = new Odcinek(punktB, punktC);
                    Odcinek AC = new Odcinek(punktA, punktC);

                    Console.WriteLine("AB: " + AB.Dlugosc());
                    Console.WriteLine("BC: " + BC.Dlugosc());
                    Console.WriteLine("AC: " + AC.Dlugosc());

                    if (Trojkat.czyTrojkat(AB.Dlugosc(), BC.Dlugosc(), AC.Dlugosc()))
                    {
                        Trojkat trojkat = new Trojkat(AB.Dlugosc(), BC.Dlugosc(), AC.Dlugosc());
                        Console.WriteLine($"Obwód trójkąta: {trojkat.obwod()}");
                        Console.WriteLine($"Pole trójkąta: {trojkat.pole()}");
                    }
                    else
                    {
                        Console.WriteLine("Podane współrzędne nie tworzą trójkąta.");
                    }

                    Console.WriteLine("Czy chcesz kontynuować? (wpisz 'n' aby zakończyć, kliknij 'enter' aby kontynuować): ");
                    string userInput = Console.ReadLine();
                    if (userInput.ToLower() == "n")
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podano nieprawidłową wartość. Proszę podać liczby w formacie dziesiętnym.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił błąd: {ex.Message}");
                }
            }
        }
    }
}

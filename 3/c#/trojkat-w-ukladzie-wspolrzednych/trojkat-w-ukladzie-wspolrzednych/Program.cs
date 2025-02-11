namespace trojkat_w_ukladzie_wspolrzednych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Trojkat");
            Punkt punktA = new Punkt();
            Punkt punktB = new Punkt();
            Punkt punktC = new Punkt();

            Console.WriteLine("Podaj współrzędną x punktu A");
            x = Convert.ToDouble(Console.ReadLine());
            punktA.setX(x);
            Console.WriteLine("Podaj współrzędną y punktu A");
            y = Convert.ToDouble(Console.ReadLine());
            punktA.setY(y);
            Console.WriteLine("Podaj współrzędną x punktu B");
            x = Convert.ToDouble(Console.ReadLine());
            punktB.setX(x);
            Console.WriteLine("Podaj współrzędną y punktu B");
            y = Convert.ToDouble(Console.ReadLine());
            punktB.setY(y);
            Console.WriteLine("Podaj współrzędną x punktu C");
            x = Convert.ToDouble(Console.ReadLine());
            punktC.setX(x);
            Console.WriteLine("Podaj współrzędną y punktu C");
            y = Convert.ToDouble(Console.ReadLine());
            punktC.setY(y);

            Console.WriteLine($"Trojkat ma wierzcholki \n"+
                $"w punkcie A o współrzędnych: X={punktA.getX()}, Y={punktA.getY()}\n"+
                $"w punkcie B o współrzędnych: X={punktB.getX()}, Y={punktB.getY()}\n"+
                $"w punkcie C o współrzędnych: X={punktC.getX()}, Y={punktC.getY()}");


            Odcinek odcinekAB = new Odcinek(punktA, punktB);
            Odcinek odcinekBC = new Odcinek(punktB, punktC);
            Odcinek odcinekCA = new Odcinek(punktC, punktA);

        }
    }
}

namespace CiagLib1
{
    public class Ciagi
    {
        public static double Arytmetyczny(double pierwszy_wyraz, double roznica, int n)
        {
            if (n == 1)
            {
                return pierwszy_wyraz;
            }
            else
            {
              return Arytmetyczny(pierwszy_wyraz, roznica, n-1)+roznica;
            }
        }
        public static double Geometryczny(double pierwszy_wyraz, double iloraz, int n)
        {
            if (n == 1)
            {
                return pierwszy_wyraz;
            }
            else
            {
                return Geometryczny(pierwszy_wyraz, iloraz, n - 1) * iloraz;
            }
        }
        public static double Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2); 
        }
    }
}

namespace MathLib1
{
    public class Algebra
    {
        static public double Suma(double x, double y)
        {
            return x+y;
        }
        static public double Roznica(double x, double y)
        {
            return x-y;
        }
    }
    public class Algebra1
    {
        static public double Iloczyn(double x, double y)
        {
            return x * y;
        }
        static public double Iloraz(double x, double y)
        {
            if (y <= 0)
            {
                return 0;
            }
            else
            {
                return x/y;
            }
                
        }
    }
}

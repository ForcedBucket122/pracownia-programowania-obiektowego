using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rk1
{
    internal class RK
    {
        public double a,b,c;

        public void Rozwiazanie()
        {
            double delta=Math.Pow(b,2)-4*a*c;
            double pierwiastekDelta = Math.Sqrt(delta);
            if(delta > 0 )
            {
                double x1 = (-b - pierwiastekDelta) / 2 * a;
                double x2 = (-b + pierwiastekDelta) / 2 * a;
                Console.WriteLine("x1= "+x1+"\nx2= "+x2);
            }
            else if(delta == 0 ) 
            {
                double x0 = -b/2 * a;
                Console.WriteLine(x0);
            }
            else
            {
                Console.WriteLine("Brak rozwiazan");
            }
        }
    }
}

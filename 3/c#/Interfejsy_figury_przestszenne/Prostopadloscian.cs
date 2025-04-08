using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy_figury_przestszenne
{
    internal class Prostopadloscian : FiguryPrzestrzenne
    {
        double a, b, c;

        public Prostopadloscian(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Objetosc()
        {
            Console.WriteLine(a*b*c);
        }

        public void PolePowierzchni()
        {
            double pole = (2 * a * b) + (2 * a * c) + (2 * b * c);
            Console.WriteLine(pole);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy_figury_przestszenne
{
    internal class Stozek : FiguryPrzestrzenne
    {

        double r, h;

        public Stozek(double r, double h)
        {
            this.r = r;
            this.h = h;
        }

        public double Objetosc()
        {
            double V=(Math.PI*Math.Pow(r,2)*h)/3;
            return V;
        }

        public double PolePowierzchni()
        {
            double l =Math.Sqrt(Math.Pow(r,2)+Math.Pow(h,2));
            double P=(Math.PI*Math.Pow(r,2))+(Math.PI*r*l);
            return P;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy_figury_przestszenne
{
    internal class Walec : FiguryPrzestrzenne
    {
        double r, h;

        public Walec(double r, double h)
        {
            this.r = r;
            this.h = h;
        }

        public double Objetosc()
        {
            double V = Math.PI * Math.Pow(r, 2) * h;
            return V;
        }

        public double PolePowierzchni()
        {
            double P=2*Math.PI*r*(r+h);
            return P;
        }
    }
}

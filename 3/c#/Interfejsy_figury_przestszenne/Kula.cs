using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy_figury_przestszenne
{
    internal class Kula : FiguryPrzestrzenne
    {
        public int r;
        public Kula(int r)
        {
            this.r = r;
        }
        public double Objetosc()
        {
            double objetosc = (4.0/3)*Math.PI*Math.Pow(r, 3);
            return objetosc;
        }

        public double PolePowierzchni()
        {
            double pole = 4*Math.PI*Math.Pow(r, 2);
            return pole;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figury_plaskie_polimorfizm
{
    internal class prostokat : figura
    {
        public double dlugosc { get; }
        public double szerokosc { get; }

        public prostokat(double dlugosc, double szerokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }

        public override double pole() => dlugosc * szerokosc;
        public override double obwod() => 2 * (dlugosc + szerokosc);
        public override string typ => "prostokąt";
    }
}

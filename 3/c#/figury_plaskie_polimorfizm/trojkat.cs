using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figury_plaskie_polimorfizm
{
    internal class trojkat:figura
    {
        public double bokA { get; }
        public double bokB { get; }
        public double bokC { get; }

        public trojkat(double bokA, double bokB, double bokC)
        {
            this.bokA = bokA;
            this.bokB = bokB;
            this.bokC = bokC;
        }

        public bool czyIstnieje() =>
            bokA + bokB > bokC && bokA + bokC > bokB && bokB + bokC > bokA;

        public override double pole()
        {
            if (!czyIstnieje()) return 0;
            double polowaObwodu = (bokA + bokB + bokC) / 2;
            return Math.Sqrt(polowaObwodu * (polowaObwodu - bokA) * (polowaObwodu - bokB) * (polowaObwodu - bokC));
        }

        public override double obwod()
        {
            if (!czyIstnieje()) return 0;
            return bokA + bokB + bokC;
        }

        //public override string typ => "trójkąt";
    }
}

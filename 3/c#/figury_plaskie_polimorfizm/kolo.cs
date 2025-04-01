using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figury_plaskie_polimorfizm
{
    internal class kolo:figura
    {
        public double promien { get; }

        public kolo(double promien)
        {
            this.promien = promien;
        }

        public override double pole() => Math.PI * Math.Pow(promien, 2);
        public override double obwod() => 2 * Math.PI * promien;
        //public override string typ => "koło";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figury_plaskie_polimorfizm
{
    internal class figura
    {
        public virtual double pole() => 0;
        public virtual double obwod() => 0;
        public virtual string typ => "nieokreślona figura";
    }
}

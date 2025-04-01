using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figury_plaskie_polimorfizm
{
    abstract internal class figura
    {
        abstract public double pole();
        abstract public double obwod();
        public string typ() => GetType().Name;
    }
}

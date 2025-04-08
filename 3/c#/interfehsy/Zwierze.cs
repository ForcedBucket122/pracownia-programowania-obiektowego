using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfehsy
{
    internal interface Zwierze:Zwierze2
    {
        public void DajGlos();
        public void Pozywienie();
        public String Typ() => GetType().Name;
    }
}

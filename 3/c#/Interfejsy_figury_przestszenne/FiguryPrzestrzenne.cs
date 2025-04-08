using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy_figury_przestszenne
{
    internal interface FiguryPrzestrzenne
    {
        public void PolePowierzchni();
        public void Objetosc();
        public String Typ()=>GetType().Name;
    }
}

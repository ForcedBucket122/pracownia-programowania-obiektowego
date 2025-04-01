using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy_abstrakcyjne
{
    internal class Kot : Zwierzeta
    {
        public override void CzymSieZywie()
        {
            Console.WriteLine("karma dla kotow");
        }

        public override void DajGlos()
        {
            Console.WriteLine("Miau miau");
        }
    }
}

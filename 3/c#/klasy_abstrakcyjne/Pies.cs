using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy_abstrakcyjne
{
    internal class Pies : Zwierzeta
    {
        public override void CzymSieZywie()
        {
            Console.WriteLine("karma dla psow");
        }

        public override void DajGlos()
        {
            Console.WriteLine("Hau Hau");
        }
        public void OPsie()
        {
            Console.WriteLine("Pies jest najlepszym przyjacielem czlowieka");
        }
    }
}

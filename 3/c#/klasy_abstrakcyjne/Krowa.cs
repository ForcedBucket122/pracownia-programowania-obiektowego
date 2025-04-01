using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy_abstrakcyjne
{
    internal class Krowa : Zwierzeta
    {
        public override void CzymSieZywie()
        {
            Console.WriteLine("karma dla krow");
        }

        public override void DajGlos()
        {
            Console.WriteLine("Tylko jedno w glowie mam...");
        }
    }
}

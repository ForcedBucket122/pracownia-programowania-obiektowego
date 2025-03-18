using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_abstrakcyjne
{
    internal class Pies : Zwierzeta
    {
        public override void DajGlos()
        {
            Console.WriteLine("Hau");
        }

        public override void Pokarm()
        {
            Console.WriteLine("Karma");
        }
    }
}

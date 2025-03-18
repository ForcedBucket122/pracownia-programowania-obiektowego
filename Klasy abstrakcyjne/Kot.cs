using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_abstrakcyjne
{
    internal class Kot : Zwierzeta
    {
        public override void DajGlos()
        {
            Console.WriteLine("Miał");
        }

        public override void Pokarm()
        {
            Console.WriteLine("Karma");
        }


    }
}

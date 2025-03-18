using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_abstrakcyjne
{
    abstract internal class Zwierzeta
    {
        abstract public void DajGlos();

        abstract public void Pokarm();

        public void PokazTypZwierzeta()
        {
            Console.WriteLine($"Jestem zwierzęciem typu: {GetType().Name}");
        }
    }
}

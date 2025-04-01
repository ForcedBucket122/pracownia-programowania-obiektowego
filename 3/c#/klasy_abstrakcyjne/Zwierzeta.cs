using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy_abstrakcyjne
{
    abstract internal class Zwierzeta
    {
        abstract public void DajGlos();
        abstract public void CzymSieZywie();
        public void Typ()
        {
            Console.WriteLine($"jestem zwierzeciem typu: {GetType().Name}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfizm
{
    internal class Pies:Zwierze
    {
        new public void DajGlos()
        {
            Console.WriteLine("glos: hau hau");
        }
        new public void Pozywienie()
        {
            Console.WriteLine("pozywienie: karma dla kota");
        }
        new public void Pozytek()
        {
            Console.WriteLine("Pozytek: pilnuje domu");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfizm
{
    internal class Kot:Zwierze
    {
        new public void DajGlos()
        {
            Console.WriteLine("glos: miau miau");
        }
        new public void Pozywienie()
        {
            Console.WriteLine("pozywienie: karma dla psa");
        }
        new public void Pozytek()
        {
            Console.WriteLine("Pozytek: lowie myszy");
        }
    }
}

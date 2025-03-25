using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfizm
{
    internal class Krowa:Zwierze
    {
        new public void DajGlos()
        {
            Console.WriteLine("glos: muu");
        }
        new public void Pozywienie()
        {
            Console.WriteLine("pozywienie: trawa i siano");
        }
        new public void Pozytek()
        {
            Console.WriteLine("Pozytek: daje mleko");
        }
    }
}

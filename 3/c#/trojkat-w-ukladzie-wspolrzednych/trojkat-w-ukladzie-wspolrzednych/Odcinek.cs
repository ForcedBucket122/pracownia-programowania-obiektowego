using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trojkat_w_ukladzie_wspolrzednych
{
    internal class Odcinek
    {
        private Punkt punkt1, punkt2;

        public Odcinek(Punkt punkt1, Punkt punkt2)
        {
            this.punkt1 = punkt1;
            this.punkt2 = punkt2;
        }
        public double dlugosc()
        {
            double d = Math.Sqrt(Math.Pow(punkt1.getX() - punkt2.getX(),2)+Math.Pow(punkt1.getY()-punkt2.getY(),2));
            return d;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkatWUkladzieWspolrzednych
{
    internal class Trojkat
    {
        double bokAB, bokBC, bokAC;

        public Trojkat(double bokAB, double bokBC, double bokAC)
        {
            this.bokAB = bokAB;
            this.bokBC = bokBC;
            this.bokAC = bokAC;
        }

        public double obwod()
        {
            return bokAB + bokAC + bokBC;
        }

        public double pole()
        {
            double p = obwod() / 2;
            return Math.Sqrt(p * (p - bokAB) * (p - bokAC) * (p - bokBC));
        }

        public static bool czyTrojkat(double bokAB, double bokBC, double bokAC)
        {
            return bokAB + bokBC > bokAC && bokAB + bokAC > bokBC && bokBC + bokAC > bokAB;
        }
    }
}
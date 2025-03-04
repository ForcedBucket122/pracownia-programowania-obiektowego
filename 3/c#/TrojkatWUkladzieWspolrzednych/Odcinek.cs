using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkatWUkladzieWspolrzednych
{
    internal class Odcinek
    {
        Punkt poczatek;
        Punkt koniec;

        public Odcinek(Punkt poczatek, Punkt koniec)
        {
            this.poczatek = poczatek;
            this.koniec = koniec;
        }

        public double Dlugosc()
        {
            while (true)
            {
                try
                {
                    double dlugosc = Math.Sqrt(Math.Pow(koniec.X - poczatek.X, 2) + Math.Pow(koniec.Y - poczatek.Y, 2));
                    return dlugosc;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił błąd podczas obliczania długości odcinka: {ex.Message}");
                }
            }
        }
        
    }
}

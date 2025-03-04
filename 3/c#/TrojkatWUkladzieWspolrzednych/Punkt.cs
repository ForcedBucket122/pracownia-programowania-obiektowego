using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkatWUkladzieWspolrzednych
{
    internal class Punkt
    {
        double x, y;

        public double X
        {
            get { return x; }
            set
            {
                while (true)
                {
                    try
                    {
                        x = value;
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Podano nieprawidłową wartość dla X. Proszę podać liczbę w formacie dziesiętnym:");
                        value = Double.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Wystąpił błąd: {ex.Message}");
                        value = Double.Parse(Console.ReadLine());
                    }
                }
            }
        }

        public double Y
        {
            get { return y; }
            set
            {
                while (true)
                {
                    try
                    {
                        y = value;
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Podano nieprawidłową wartość dla Y. Proszę podać liczbę w formacie dziesiętnym:");
                        value = Double.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Wystąpił błąd: {ex.Message}");
                        value = Double.Parse(Console.ReadLine());
                    }
                }
            }
        }
    }
}

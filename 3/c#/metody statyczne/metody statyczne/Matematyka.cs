using System;

namespace metody_statyczne
{
    public static class Matematyka
    {
        // 1. Metoda obliczająca silnię liczby naturalnej
        public static long Silnia(int n)
        {
            if (n < 0) throw new ArgumentException("Liczba musi być naturalna (n >= 0).");
            long wynik = 1;
            for (int i = 1; i <= n; i++)
            {
                wynik *= i;
            }
            return wynik;
        }

        // 2. Metoda obliczająca potęgę liczby rzeczywistej
        public static double Potega(double podstawa, int wykladnik)
        {
            double wynik = 1;
            int absWykladnik = wykladnik < 0 ? -wykladnik : wykladnik;
            for (int i = 0; i < absWykladnik; i++)
            {
                wynik *= podstawa;
            }
            if (wykladnik < 0)
            {
                wynik = 1 / wynik;
            }
            return wynik;
        }

        // 3. Metoda sprawdzająca, czy liczba jest pierwsza
        public static bool CzyPierwsza(int liczba)
        {
            if (liczba <= 1) return false;
            for (int i = 2; i * i <= liczba; i++)
            {
                if (liczba % i == 0) return false;
            }
            return true;
        }

        // 4. Metoda sprawdzająca, czy liczba jest doskonała
        public static bool CzyDoskonala(int liczba)
        {
            if (liczba <= 1) return false;
            int sumaDzielnikow = 1;
            for (int i = 2; i <= liczba / 2; i++)
            {
                if (liczba % i == 0)
                {
                    sumaDzielnikow += i;
                }
            }
            return sumaDzielnikow == liczba;
        }

        // 5. Algorytm Euklidesa do obliczania NWD
        public static int NWD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}

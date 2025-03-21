﻿namespace zadanie { 
    /*napisz program tabliczka mnozenia na liczbach całkowitych z przedziału <0,10> włącznie.
    Urzytkownik podaje liczby z tego zakresu a nastepnie wyswietla sie mnozenie na tych liczbach i wynik.
    W przypadku podania niewlasciwych danych program zapetla sie i uzytkownik ponownie musi podac dana az poda poprawna, kazda osobno.
    Caly program dziala w petli z opcjami wyboru np. 1-tabliczka mnozenia albo licz a 0 to wyjscie z programu */
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWybierz opcję: ");
                Console.WriteLine("1. Tabliczka mnożenia");
                Console.WriteLine("0. Wyjście z programu");

                try
                {
                    byte opcja = Convert.ToByte(Console.ReadLine());

                    switch (opcja)
                    {
                        case 1:
                            int liczba1 = PobierzLiczbe("Podaj pierwszą liczbę (0-10): ");
                            int liczba2 = PobierzLiczbe("Podaj drugą liczbę (0-10): ");
                            int wynik = liczba1 * liczba2;
                            Console.WriteLine($"{liczba1} * {liczba2} = {wynik}");
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Podaj liczbę 0 lub 1.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Niewłaściwy format!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static int PobierzLiczbe(string komunikat)
        {
            int liczba;
            while (true)
            {
                Console.Write(komunikat);
                try
                {
                    liczba = Convert.ToInt32(Console.ReadLine());
                    if (liczba >= 0 && liczba <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Liczba musi być z przedziału 0-10.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Niewłaściwy format! Podaj liczbę całkowitą.");
                }
            }
            return liczba;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj rozmiar tablicy: ");
            int rozmiar = int.Parse(Console.ReadLine());

            if (rozmiar <= 0)
            {
                Console.WriteLine("Niepoprawny rozmiar tablicy.");
                return;
            }

            int[,] tablica = new int[rozmiar, rozmiar];

            for (int numerWiersza = 0; numerWiersza < rozmiar; numerWiersza++)
            {
                if (numerWiersza % 2 == 0) // Parzyste wiersze
                {
                    for (int numerKolumny = 0; numerKolumny < rozmiar; numerKolumny++)
                    {
                        tablica[numerWiersza, numerKolumny] = numerWiersza * rozmiar + numerKolumny + 1;
                    }
                }
                else // Nieparzyste wiersze
                {
                    for (int numerKolumny = 0; numerKolumny < rozmiar; numerKolumny++)
                    {
                        tablica[numerWiersza, numerKolumny] = (numerWiersza + 1) * rozmiar - numerKolumny;
                    }
                }
            }

            for (int numerWiersza = 0; numerWiersza < rozmiar; numerWiersza++)
            {
                for (int numerKolumny = 0; numerKolumny < rozmiar; numerKolumny++)
                {
                    Console.Write(tablica[numerWiersza, numerKolumny] + " ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}

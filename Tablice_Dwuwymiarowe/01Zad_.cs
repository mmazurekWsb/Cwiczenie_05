using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Zad
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[,] tablica = new int[10, 10];

            for (int numerWiersza = 0; numerWiersza < 10; numerWiersza++)
            {
                if (numerWiersza % 2 == 0) // Parzyste wiersze
                {
                    for (int numerKolumny = 0; numerKolumny < 10; numerKolumny++)
                    {
                        tablica[numerWiersza, numerKolumny] = numerWiersza * 10 + numerKolumny + 1;
                    }
                }
                else // Nieparzyste wiersze
                {
                    for (int numerKolumny = 0; numerKolumny < 10; numerKolumny++)
                    {
                        tablica[numerWiersza, numerKolumny] = (numerWiersza + 1) * 10 - numerKolumny;
                    }
                }
            }

            for (int numerWiersza = 0; numerWiersza < 10; numerWiersza++)
            {
                for (int numerKolumny = 0; numerKolumny < 10; numerKolumny++)
                {
                    Console.Write(tablica[numerWiersza, numerKolumny] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

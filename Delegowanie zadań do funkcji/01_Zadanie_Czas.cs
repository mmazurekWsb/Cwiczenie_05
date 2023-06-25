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
            int czas = 332;
            string sformatowanyCzas = FormatujCzas(czas);
            Console.WriteLine(sformatowanyCzas); // Wyświetli: 00:05:32
            Console.ReadKey();
        }

        static string FormatujCzas(int czas)
        {
            int godziny = czas / 3600;
            int minuty = (czas % 3600) / 60;
            int sekundy = czas % 60;

            return $"{godziny:D2}:{minuty:D2}:{sekundy:D2}";
        }
    }
}

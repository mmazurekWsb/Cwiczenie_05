using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _02Zadanie
{
    internal class _02ZadanieDlugoscOdcinka
    {
        static void Main(string[] args)
        {
            double x1 = 3.5;
            double y1 = 2.0;
            double x2 = 8.2;
            double y2 = 4.7;

            double dlugoscOdcinka = ObliczDlugoscOdcinka(x1, y1, x2, y2);
            Console.WriteLine("Długość odcinka: " + dlugoscOdcinka);
            Console.ReadKey();
        }

        static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            double dlugosc = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return dlugosc;
        }
    }
}

        
 
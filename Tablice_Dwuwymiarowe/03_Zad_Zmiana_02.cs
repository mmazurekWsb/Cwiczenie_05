using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Zad_Zmiana02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy (liczba wierszy):");
            int size;
            bool validInput = int.TryParse(Console.ReadLine(), out size);

            while (!validInput || size <= 0)
            {
                Console.WriteLine("Niepoprawne dane. Podaj prawidłowy rozmiar tablicy:");
                validInput = int.TryParse(Console.ReadLine(), out size);
            }

            int[,] array = new int[size, size];
            int currentCol = 0;
            int currentRow = 0;
            int direction = 0; // 0- prawo; 1 -dół , 2 - lewo, 3 -góra

            for (int currentNumber = 1; currentNumber <= size * size; currentNumber++)
            {
                array[currentRow, currentCol] = currentNumber;
                switch (direction)
                {
                    case 0: //w prawo
                        if (currentCol + 1 >= size || array[currentRow, currentCol + 1] != 0)
                        {
                            direction = 1;
                            currentRow++;
                        }
                        else
                        {
                            currentCol++;
                        }
                        break;

                    case 1:
                        if (currentRow + 1 >= size || array[currentRow + 1, currentCol] != 0)
                        {
                            direction = 2; // przemieszzamu sie w lewo
                            currentCol--;
                        }
                        else
                        {
                            currentRow++;
                        }
                        break;
                    case 2:
                        if (currentCol - 1 < 0 || array[currentRow, currentCol - 1] != 0)
                        {
                            direction = 3;
                            currentRow--;
                        }
                        else
                        {
                            currentCol--;
                        }
                        break;
                    case 3://w górę
                        if (currentRow - 1 < 0 || array[currentRow - 1, currentCol] != 0)
                        {
                            direction = 0;
                            currentCol++;
                        }
                        else
                        {
                            currentRow--;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Tablica({0}x{0}):", size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0, 3}", array[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

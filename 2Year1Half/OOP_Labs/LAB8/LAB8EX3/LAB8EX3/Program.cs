using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            PwrOfTwo pwr = new PwrOfTwo();
            Console.Write("Первые 8 степеней числа 2: ");
            for (int i = 0; i < 8; i++)
                Console.Write(pwr[i] + " ");
            Console.WriteLine();
            Console.Write("А это некоторые ошибки: ");
            Console.Write(pwr[-2] + " " + pwr[17]);
            Console.WriteLine();
            Console.ReadKey();
        }
        class PwrOfTwo
        {
            /* Доступ к логическому массиву, содержащему степени
            числа 2 от 0 до 15. */
            public double this[int index]
            {
                // Вычислить и возвратить степень числа 2.
                get
                {
                    if ((index >= 0) && (index < 16)) return pwr(index, true);
                    else if (index < 0) return pwr(index, false);
                    else return -1;
                }
                // Аксессор set отсутствует.
            }
            double pwr(int p, bool high)
            {
                if (high == true)
                {
                    int result = 1;
                    for (int i = 0; i < p; i++)
                        result *= 2;
                    return result;
                }
                else
                {
                    double result = 1;
                    for (int i = 1; i < Math.Abs(p)+1; i++)
                        result *= Math.Pow(2, -1);
                    return result;
                }
            }
        }
    }
}

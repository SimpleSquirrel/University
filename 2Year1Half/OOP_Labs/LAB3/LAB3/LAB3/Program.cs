using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool close = false;
            int choose;
            while(close == false)
            {
                Console.WriteLine("Введите номер задания");
                Console.WriteLine
                    ("1 - Больше-меньше\n" +
                     "2 - Большее из 3 чисел\n" +
                     "3 - switch\n" +
                     "4 - формула\n" +
                     "5 - выход");
                choose = Int32.Parse(Console.ReadLine());
                switch(choose)
                {
                    case 1:
                        {
                            Ex1();
                            break;
                        }
                    case 2:
                        {
                            Ex2();
                            break;
                        }
                    case 3:
                        {
                            Ex3();
                            break;
                        }
                    case 4:
                        {
                            Ex4();
                            break;
                        }
                    case 5:
                        {
                            close = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введите число от 1 до 5");
                            break;
                        }
                }
            }
        }
        private static void Ex1()
        {
            double x, y;
            Console.WriteLine("Введите 2 числа");
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            if (x > y)
                Console.WriteLine(x);
            else if (x < y)
                Console.WriteLine(y);
            else
                Console.WriteLine("Эти числа одинаковые");
        }
        private static void Ex2()
        {
            double a, b, c;
            Console.WriteLine("Введите 3 числа");
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine()); 
            c = Double.Parse(Console.ReadLine());

            Console.WriteLine("Max: " + Math.Max(Math.Max(a, b), c));
        }
        private static void Ex3()
        {
            string day;
            Console.WriteLine("Введите номер дня недели");
            day = Console.ReadLine();
            switch (day)
            {
                case "1":
                    {
                        Console.WriteLine("Понедельник");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Вторник");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Среда");
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Четверг");
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("Пятница");
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("Суббота");
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine("Воскресенье");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вы ввели что-то неправильно");
                        break;
                    }
            }
        }
        private static void Ex4()
        {
            int n;
            double res = 0;
            Console.WriteLine("Введите n");
            n = Int32.Parse(Console.ReadLine());
            for(int i = 1; i< n*2+1;i++)       
                res += Math.Pow(-1, i + 1) / (i * Math.Pow(i + 1, 1 / i));
            Console.WriteLine("Result: " + res);
        }
    }
}

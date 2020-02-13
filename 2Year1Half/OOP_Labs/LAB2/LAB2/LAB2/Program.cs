using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool close = false;
            int choose;
            
            while(close == false)
            {
                Console.WriteLine("Выберите номер задания");
                Console.WriteLine
                   ("1 - Сумма 3х чисел\n" +
                    "2 - Остаток от деления\n" +
                    "3 - Значение функции\n" +
                    "4 - Густота\n" +
                    "5 - Анкета\n" +
                    "6 - Выход");
                choose = Int32.Parse(Console.ReadLine());

                switch (choose)
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
                            Ex5();
                            break;
                        }
                    case 6:
                        {
                            close = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Вы ввели что-то нерпавильно, введите число от 1 до 6");
                            break;
                        }
                }
            }
        }
        private static void Ex1()
        {
            int a, b;
            Console.WriteLine("Введите 3 целых числа");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            a += b;
            b = Int32.Parse(Console.ReadLine());
            a += b;
            Console.WriteLine("Result: " + a);
        }
        private static void Ex2()
        {
            double a, b;
            Console.WriteLine("Введите два числа");
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Result: " + a % b);
        }
        private static void Ex3()
        {
            double x, y;
            Console.WriteLine("Введите Х");
            x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Result: " + (2 * Math.Pow(x, 2) + 10 * x + 40));
        }
        private static void Ex4()
        {
            int people;
            double area;
            Console.WriteLine("Введите кол-во людей и площадь");
            people = System.Convert.ToInt32(Console.ReadLine());
            area = System.Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + people / area + " на кв.км");
        }
        private static void Ex5()
        {
            string name, surname, age, group, course;
            Console.WriteLine("Введите имя, фамилию, возраст, группу, курс");
            name = Console.ReadLine();
            surname = Console.ReadLine();
            age = Console.ReadLine();
            group = Console.ReadLine();
            course = Console.ReadLine();
            Console.WriteLine
                ("Имя: " + name +
               "\nФамилия: " + surname +
               "\nВозраст: " + age +
               "\nКурс: " + course +
               "\nГруппа: " + group);
        }
    }
}

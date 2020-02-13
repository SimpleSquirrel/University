using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
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
                    ("1 - простые числа\n" +
                     "2 - массив\n" +
                     "3 - успешность группы\n" +
                     "4 - уравнение\n" +
                     "5 - максимум и минимум + рандом\n" +
                     "6 - колово цифр\n" +
                     "7 - максимум и минимум\n" +
                     "8 - поиск\n" +
                     "9 - бинарный поиск\n" +
                     "10 - выход");


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
                            Ex5();
                            break;
                        }
                    case 6:
                        {
                            Ex6();
                            break;
                        }
                    case 7:
                        {
                            Ex7();
                            break;
                        }
                    case 8:
                        {
                            Ex8();
                            break;
                        }
                    case 9:
                        {
                            Ex9();
                            break;
                        }
                    case 10:
                        {
                            close = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введите число от 1 до 10");
                            break;
                        }
                }
            }
        }
        private static void Ex1()
        {
            int[] mas = new int[101];
            for (int i = 0; i < mas.Length; i++)
                mas[i] = i + 1;
            foreach (int i in mas)
                Console.Write(i + "\t");
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] != 0)
                {
                    for (int j = i+1; j < mas.Length - 1; j++)
                    {
                        if (mas[j] != 0 && mas[j] % mas[i] == 0 && mas[i]!=1)
                        {
                            mas[j] = 0;
                        }
                    }
                }
            }
            Console.WriteLine();
            foreach (int i in mas)  
                if(i!=0)
                    Console.Write(i + "\t");
            Console.WriteLine();
        }
        private static void Ex2()
        {
            Random rand = new Random();
            int plus;
            Console.WriteLine("На сколько увеличить?");
            plus = Int32.Parse(Console.ReadLine());
            int[] mas = new int[10];
            for (int i = 0; i < mas.Length; i++)
                mas[i] = rand.Next(0, 100);
            foreach (int i in mas)
                Console.Write(i + "\t");
            Console.WriteLine();

            for (int i = 0; i < mas.Length; i++)
                mas[i] -= 20;
            foreach (int i in mas)
                Console.Write(i + "\t");
            Console.WriteLine();

            for (int i = 0; i < mas.Length; i++)
                mas[i] *= mas[mas.Length-1];
            foreach (int i in mas)
                Console.Write(i + "\t");
            Console.WriteLine();

            for (int i = 0; i < mas.Length; i++)
                mas[i] += plus;
            foreach (int i in mas)
                Console.Write(i + "\t");
            Console.WriteLine();
        }
        private static void Ex3()
        {
            Random rand = new Random();
            int[,] mas = new int[20,10];
            double[] res = new double[10];


            for(int i = 0;i<20;i++)
                for(int j = 0;j<10;j++)
                    mas[i, j] = rand.Next(0, 12);

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < 10; i++)
            {
                double sred = 0.0;
                for (int j = 0; j < 20; j++)
                {
                    sred += mas[j,i];
                }
                sred /= 20;
                res[i] = sred;
            }
            
            Console.WriteLine();
            foreach (double i in res)
                Console.Write(i + "\t");
            Console.WriteLine();

        }
        private static void Ex4()
        {
            Console.WriteLine($"x1 = {bis(-40, 0)}\nx2 = {bis(0, 1283)}");
        }
        private static void Ex5()
        {
            Random rand = new Random();
            double[] mas = new double[4];
            for (int i = 0; i < 4; i++)
                mas[i] = rand.NextDouble() * (100 - 1) + 1;

            for (int i = 0; i < 4; i++)
                Console.Write(mas[i] + "\t");
            Console.WriteLine();
            double answer = Math.Max(mas[0], Math.Max(mas[1], Math.Max(mas[2], mas[3])));
            Console.WriteLine("Самое большое число: " + answer);
        }
        private static void Ex6()
        {
            int num, amount = 0;
            int[] mas = new int[] { 1, 2, 5, 3, 7, 5, 1, 3, 4 };
            Console.WriteLine("Введите число, кол-во которого хотите узнать");
            num = Int32.Parse(Console.ReadLine());
            foreach (int i in mas)
                if (i == num)
                    amount++;
            Console.WriteLine("Количество " + num + " в массиве = " + amount);
        }
        private static void Ex7()
        {
            int[] mas = new int[] { 4, 5, 2, 3, 8, 7, 6, 1 };
            int max = mas[0], min = mas[0];
            foreach(int i in mas)
            {
                if (max < i)
                    max = i;
                if (min > i)
                    min = i;
            }
            Console.WriteLine("Max: " + max + "\nMin: " + min);
        }
        private static void Ex8()
        {
            int num;
            Random rand = new Random();
            int[] mas = new int[100];

            for(int i = 0;i<100;i++)
                mas[i] = rand.Next(1, 99);
            for(int i = 0;i<99;i++)
                for(int j = 0; j<99;j++)
                    if(mas[j] > mas[j+1])
                    {
                        int save = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = save;
                    }
            foreach(int i in mas)
                Console.Write(i+"\t");
            Console.WriteLine();
            Console.WriteLine("Введите число, которое вам нужно найти");
            num = Int32.Parse(Console.ReadLine());
            int half=0, bot = 0, top = 99;
            while (bot <= top)
            {
                half = (top + bot) / 2;
                if (mas[half] > num)
                    top = half - 1;
                else 
                    if (mas[half] < num)
                        bot = half + 1;
                    else 
                        break;
            }half++;
            Console.WriteLine("Это число стоит на " + half+ " позиции");

        }
        private static void Ex9()
        {
            int num;
            Random rand = new Random();
            int[] mas = new int[100];

            for (int i = 0; i < 100; i++)
                mas[i] = rand.Next(1, 99);
            for (int i = 0; i < 99; i++)
                for (int j = 0; j < 99; j++)
                    if (mas[j] > mas[j + 1])
                    {
                        int save = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = save;
                    }
            foreach (int i in mas)
                Console.Write(i + "\t");
            Console.WriteLine();
            Console.WriteLine("Введите число, которое вам нужно найти");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Array.BinarySearch(mas, num)+1);
        }
        private static double fun(double x)
        {
            return (Math.Pow(x, 4) - (13 * Math.Pow(x, 2)) + 36);
        }
        private static double bis(double left, double right)
        {
            double eps = 0.00001;
            double center = 0;
            do
            {
                center = left + (right - left) / 2;
                Console.WriteLine($"Kordinata: {center},  otvet: {fun(center)}");
                if (fun(center) == 0) break;
                if (center > 0)
                {
                    if (fun(center) > 0)
                    {
                        right = center;
                    }
                    else
                    {
                        left = center;
                    }
                }
                else
                {
                    if (fun(center) > 0)
                    {
                        left = center;
                    }
                    else
                    {
                        right = center;
                    }
                }

            } while (right - left > eps);
            Console.WriteLine();
                return center;
        }
        /*
         c = a + 0.5 * (b - a);
                fc = Convert.ToDouble(f(c));
                lich++;
                if (Math.Abs(fc) < eps) break;
                if (fa * fc < 0) b = c; else a = c;
         */

    }
}

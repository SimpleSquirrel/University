using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8EX3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            middleRating();
        }
        public static void middleRating()
        {
            Student student = new Student("Sanya", "Vsiliev", "V2t", "123123", 16, "+380123812", 1);
            int[] mas = new int[10];
            Console.WriteLine("Ввеидте последовательно оценки");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Int32.Parse(Console.ReadLine());
            }
            student.setMarks(mas);
            student.middleScore();
            Console.ReadKey();
        }
    }
    class middleRating
    {
        public double this[int index]
        {
            get
            {
                int[] mas = new int[index];
                Console.WriteLine("Ввеидте последовательно оценки");
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = Int32.Parse(Console.ReadLine());
                }
                double res = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    res += mas[i];
                }
                return res;
            }
        }
    }
}

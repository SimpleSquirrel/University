using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            newStudent();
            middleRating();
        }
        public static void newStudent()
        {
            bool close = false;
            while (close == false)
            {
                string name;
                string surname;
                string adress;
                string passport;
                int age;
                string telephone;
                int rating;



                Console.WriteLine("Введите имя, фамилию,адресс, паспорт, возвраст, телефон, рейтинг");

                name = Console.ReadLine();
                if (name.Equals("EXIT")) { close = true; break; }
                surname = Console.ReadLine();
                adress = Console.ReadLine();
                passport = Console.ReadLine();
                age = Int32.Parse(Console.ReadLine());
                telephone = Console.ReadLine();
                rating = Int32.Parse(Console.ReadLine());
                Student student = new Student(name, surname, adress, passport, age, telephone, rating);

                string[] XX = File.ReadAllLines("W:/ООП/LAB7/LAB7EX1/students.txt", Encoding.GetEncoding(1251));
                string[] AS = new string[XX.Length + 1];
                for(int i = 0;i<XX.Length;i++)
                {
                    AS[i] = XX[i];
                }
                Console.WriteLine("DONE!");
                AS[AS.Length-1] +=( name + "\t" +
                    surname + "\t" +
                    adress + "\t" +
                    passport + "\t" +
                    age.ToString() + "\t" +
                    telephone + "\t" +
                    rating.ToString());
                
                for(int i = 0;i<AS.Length;i++)
                {
                    string[] str1 = AS[i].Split('\t');
                    for(int j = 0;j<AS.Length-1;j++)
                    {
                        string[] str2 = AS[j].Split('\t');
                        if (Int32.Parse(str2[6]) > Int32.Parse(str1[6]))
                        {
                            string save = AS[j];
                            AS[j] = AS[i];
                            AS[i] = save;
                        }
                    }
                }
                for(int i = 0; i < AS.Length; i++)
                {
                    Console.WriteLine(AS[i]);
                }
                
                FileStream f = new FileStream("W:/ООП/LAB7/LAB7EX1/students.txt", FileMode.Open); 
                StreamWriter wstream = new StreamWriter(f);

                f.Seek(0, SeekOrigin.Current);
                for(int i = 0;i<AS.Length;i++)
                {
                    wstream.WriteLine(AS[i]);
                }
                wstream.Close();
            }
            Console.ReadKey();
        }
        public static void middleRating()
        {
            Student student = new Student("Sanya", "Vsiliev", "V2t","123123",16,"+380123812",1);
            int[] mas = new int[10];
            Console.WriteLine("Ввеидте последовательно оценки");
            for(int i = 0;i<mas.Length;i++)
            {
                mas[i] = Int32.Parse(Console.ReadLine());
            }
            student.setMarks(mas);
            student.middleScore();
            Console.ReadKey();
        }
    }
}

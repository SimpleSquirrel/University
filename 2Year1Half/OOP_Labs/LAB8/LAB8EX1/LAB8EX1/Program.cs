using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pers = new Program();

            pers.DOEX("sdfsd 123 231");
            Console.ReadKey();
        }

        const int l_name = 10;
        string name;
        int birth_year;
        double pay;

        public Program() // конструктор без параметрів
        {
            name = "Anonimous";
            birth_year = 0;
            pay = 0;
        }
        public Program(string s) // 2 конструктор з параметром
        {
            name = s.Substring(0, l_name);
            birth_year = Convert.ToInt32(s.Substring(l_name, 4));
            pay = Convert.ToDouble(s.Substring(l_name + 4));
            if (birth_year < 0) throw new FormatException();
            if (pay < 0) throw new FormatException();
        }
        public void DOEX(string s)
        {
            string[] mas = s.Split(' ');
            name = mas[0];
            birth_year = Int32.Parse(mas[1]);
            pay = Double.Parse(mas[2]);
            Console.WriteLine("Name: " + name + "\nBirth Day: " + birth_year + "\nPay: " + pay);
        }

        public override string ToString() // 3 перевизначений метод
        {
            return string.Format("Name: {0,10} birth: {1} pay: {2:F2}", name, birth_year, pay);
        }
        public int Compare(string name) // порівняння прізвища
        {
            return (string.Compare(this.name, 0, name + " ", 0, name.Length + 1, StringComparison.OrdinalIgnoreCase));
        }
        // -------------------- властивості класу --------------------------
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Birth_year
        {
            get { return birth_year; }
            set
            {
                if (value > 0) birth_year = value;
                else throw new FormatException();
            }
        }
        public double Pay
        {
            get { return pay; }
            set
            {
                if (value > 0) pay = value;
                else throw new FormatException();
            }
        }
        // ------------------ операції класу ---------------------------
        public static double operator +(Program pers, double a)
        {
            pers.pay += a;
            return pers.pay;
        }
        public static double operator +(double a, Program pers)
        {
            pers.pay += a;
            return pers.pay;
        }
        public static double operator -(Program pers, double a)
        {
            pers.pay -= a;
            if (pers.pay < 0) throw new FormatException();
            return pers.pay;
        }
    };
}
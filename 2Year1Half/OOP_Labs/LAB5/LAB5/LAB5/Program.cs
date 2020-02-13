using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool close = false;
            int choose;


            while (close == false)
            {
                Console.WriteLine("Введите номер задания");
                Console.WriteLine
                    ("1 - одинаковые буквы\n" +
                     "2 - идентификатор\n" +
                     "3 - строка в столб\n" +
                     "4 - удалить слово\n" +
                     "5 - string калькулятор\n" +
                     "6 - выход");
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
                            Console.WriteLine("Введите число от 1 до 6");
                            break;
                        }
                }
            }
        }
        private static void Ex1()
        {
            string str1, str2, answer = "";
            Console.WriteLine("Введите 2 слова на проверку");
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();

            foreach(char ch1 in str1)
            {
                foreach(char ch2 in str2)
                {
                    if (ch1 == ch2)
                        answer += ch1;
                }
            }
            Console.WriteLine(answer.Distinct().ToArray());
        }
        private static void Ex2()
        {
            Console.WriteLine("Введите строку на проверку идентификатора");
            char[] line = Console.ReadLine().ToCharArray();

            Console.WriteLine($"Является ли строка идентификатором? Ответ: {IsValid(line)}");
            Console.WriteLine();
        }
        private static bool IsValid(char[] ch)
        {
            if (!is_identifier_start_character(ch[0]))
                return false;

            for (int i = 1; i < ch.Length; i++)
                if (!is_identifier_part_character(ch[i]))
                    return false;
            for(int i =0;i<keywords.Length;i++)
            {
                if (ch.ToString().Equals(keywords[i]))
                    return false;
            }
            return true;
        }
        private static string[] keywords = new string[] {
    "abstract","event","new","struct","as","explicit","null","switch","base","extern",
    "this","false","operator","throw","break","finally","out","true",
    "fixed","override","try","case","params","typeof","catch","for",
    "private","foreach","protected","checked","goto","public",
    "unchecked","class","if","readonly","unsafe","const","implicit","ref",
    "continue","in","return","using","virtual","default",
    "interface","sealed","volatile","delegate","internal","do","is",
    "sizeof","while","lock","stackalloc","else","static","enum",
    "namespace",
    "object","bool","byte","float","uint","char","ulong","ushort",
    "decimal","int","sbyte","short","double","long","string","void",
    "partial", "yield", "where"
};
        internal static bool is_identifier_start_character(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '_' || c == '@' || char.IsLetter(c);
        }

        internal static bool is_identifier_part_character(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c == '_' || (c >= '0' && c <= '9') || char.IsLetter(c);
        }


        private static void Ex3()
        {
            Console.WriteLine("Введите название клуба");
            string str = Console.ReadLine();
            foreach (char line in str)
                Console.WriteLine(line);

        }
        private static void Ex4()
        {
            string str = "Язык программирования С#";
            Console.WriteLine(str);
            str = str.Replace("программирования ", "");
            Console.WriteLine(str);
        }
        private static void Ex5()
        {
            string str, operation;
            int[] nums = new int[2];
            try
            {
                do
                {
                    Console.WriteLine("Введите пример");
                    str = Console.ReadLine();
                    operation = str.Replace("0", "").Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "")
                                   .Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "");
                    if (str.Equals("Exit")) break;
                    nums[0] = Int32.Parse(str.Substring(0, str.Length - str.IndexOf(operation)));
                    nums[1] = Int32.Parse(str.Replace(nums[0].ToString(), "").Replace(operation, ""));


                    switch (operation)
                    {
                        case "+":
                            {
                                Console.WriteLine(nums[0] + nums[1]);
                                break;
                            }
                        case "-":
                            {
                                Console.WriteLine(nums[0] - nums[1]);
                                break;
                            }
                        case "*":
                            {
                                Console.WriteLine((double)nums[0] * nums[1]);
                                break;
                            }
                        case "/":
                            {
                                Console.WriteLine((double)nums[0] / nums[1]);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Вы ввели что-то неправильно");
                                break;
                            }
                    }
                } while (str != "Exit");
            }
            catch (Exception e) { }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fstream = new FileStream("W:/ООП/LAB6/LAB6EX1/answer.txt", FileMode.OpenOrCreate);
            StreamWriter wstream = new StreamWriter(fstream);

            string[] line = File.ReadAllLines("W:/ООП/LAB6/LAB6EX1/trytosolve.txt");
            string operation, str = line[0];
            int[] nums = new int[2];  

            operation = str.Replace("0", "").Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "")
                           .Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "");

            nums[0] = Int32.Parse(str.Substring(0, str.Length - str.IndexOf(operation)));
            nums[1] = Int32.Parse(str.Replace(nums[0].ToString(), "").Replace(operation, ""));


            switch (operation)
            {
                case "+":
                    {
                        wstream.WriteLine(nums[0] + nums[1]);
                        
                        break;
                    }
                case "-":
                    {
                        wstream.WriteLine(nums[0] - nums[1]);
                        break;
                    }
                case "*":
                    {
                        wstream.WriteLine((double)nums[0] * nums[1]);
                        break;
                    }
                case "/":
                    {
                        wstream.WriteLine((double)nums[0] / nums[1]);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вы ввели что-то неправильно");
                        break;
                    }
            }
            wstream.Close();
            Console.ReadKey();
        }
    }
}

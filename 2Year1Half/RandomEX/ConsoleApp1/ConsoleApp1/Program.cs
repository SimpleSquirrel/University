using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            b:
            char x = '2', y = '0';
            Console.WriteLine(((int)x)+((int)y));
            Console.WriteLine(2-0.0);
            goto b;
        }
    }
}

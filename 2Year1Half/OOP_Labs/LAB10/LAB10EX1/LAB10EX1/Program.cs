using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Town town = new Town();
            Village village = new Village("Name123123", "Add123123123", 250);

            town.amount_of_buildings = 100;
            village.amount_of_shools = 3;
            Console.WriteLine("Поля из интерфейса");
            Console.WriteLine(town.amount_of_buildings);
            Console.WriteLine(village.amount_of_shools);

            Console.WriteLine("\nМетоды из интерфейса");
            Console.WriteLine(town.Get_Population());
            Console.WriteLine(village.Get_Population());

            Console.WriteLine("\n");
            Console.WriteLine(town.Get_Area());
            village.showInfo();

            Console.ReadKey();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10EX2
{
    public class Place
    {
        private int Amount_of_buildings;
        public int amount_of_buildings
        {
            set
            {
                Amount_of_buildings = value;
                Console.WriteLine("Работает setter");
            }
            get
            {
                Console.WriteLine("Работает getter");
                return Amount_of_buildings;
            }
        }

        private int Amount_of_shools;
        public int amount_of_shools
        {
            set
            {
                Amount_of_shools = value;
            }
            get
            {
                return Amount_of_buildings;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10EX2
{
    class Village : Place, Address_area
    {
        public string Name;
        public string Address;
        public int population;

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        public int Get_Population()
        {
            return population;
        }

        public string Get_Area()
        {
            return ("СУПЕР МЕСТНОСТЬ С АДРЕССОМ: " + address);
        }
        public Village()
        {
            name = "name";
            address = "address";
            population = 0;
        }
        public Village(string name, string address, int population)
        {
            this.name = name;
            this.address = address;
            this.population = population;
        }
        public void showInfo()
        {
            Console.WriteLine($"Name: {Name}\nAddress: {Address}\nPopulation: {population}");
        }
    }
}

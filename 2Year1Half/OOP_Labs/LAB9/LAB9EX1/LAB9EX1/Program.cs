using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Place place = new Place("Name", 100, 150);
            place.Display();
            
            Village vil = new Village("ава", 1, 1,"Hui");
            vil.Display();

            Town town = new Town("TOWN", 2, 2, "MAYOR", 10);
            town.Display();

            Console.ReadKey();
        }
    }
    class Place
    {
        string name;
        int people;
        int space;

        public Place()
        {
            name = "";
            people = 0;
            space = 0;
        }
        public Place(string name, int people, int space)
        {
            this.name = name;
            this.people = people;
            this.space = space;
        }


        public virtual void Density()
        {
            Console.WriteLine("Density: " + people / space);
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {name}\nPeople: {people}\nSpace: {space}");
        }
    }

    class Village : Place
    {
        string sherif;

        public void sher()
        {
            Console.WriteLine($"This village has been protected by {sherif}");
        }


        public Village() { }
        public Village(string name, int people, int space,string sherif) : base(name, people, space)
        {
            this.sherif = sherif;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Sherif of this village is {sherif}");
        }

    }

    class Town : Place
    {
        string mayor;
        int mayor_period;

        public void mayor_of_town()
        {
            Console.WriteLine($"Mayors name is {mayor}");
        }

        public Town() { }
        public Town(string name, int people, int space, string mayor, int mayor_period) : base(name, people, space)
        {
            this.mayor = mayor;
            this.mayor_period = mayor_period;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Mayor: {mayor} is {mayor_period} years in a row");
        }
    }
}

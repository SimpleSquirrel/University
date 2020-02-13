using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7EX3v2
{
    class Place
    {
        private string type;
        private string location;
        private double size;

        public Place()
        {
            type = "";
            location = "";
            size = 0.0;
        }
        public Place(string type, string location, double size)
        {
            this.type = type;
            this.location = location;
            this.size = size;
        }
        public string getType()
        {
            return type;
        }
        public string getLocation()
        {
            return location;
        }
        public double getSize()
        {
            return size;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public void setLocation(string location)
        {
            this.location = location;
        }
        public void setSize(double size)
        {
            this.size = size;
        }
        public void showInfo()
        {
            Console.WriteLine("Тип местности: " + type + "\nЛокация: " + location + "\nПлощадь: " + size);
        }
    }
}

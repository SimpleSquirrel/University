using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7EX3v2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            int choose;
            Place place = new Place();
            while (stop == false)
            {
                Console.WriteLine(
                      "0 - Ввести данные" +
                    "\n1 - Вывести тип" +
                    "\n2 - Вывести локацию" +
                    "\n3 - Вывести площадь" +
                    "\n4 - Заменить тип" +
                    "\n5 - Заменить локацию" +
                    "\n6 - Заменить площадь" +
                    "\n7 - Вывести информацию" +
                    "\n8 - Выход");
                choose = Int32.Parse(Console.ReadLine());
                switch(choose)
                {
                    case 0:
                        {
                            string type, location;
                            double size;
                            Console.WriteLine("Введите тип, лоацию и её площадь");
                            type = Console.ReadLine();
                            location = Console.ReadLine();
                            size = Double.Parse(Console.ReadLine());
                            place = new Place(type, location, size);
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine(place.getType());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(place.getLocation());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(place.getSize());
                            break;
                        }
                    case 4:
                        {
                            string type;
                            type = Console.ReadLine();
                            place.setType(type);
                            Console.WriteLine("Done!");
                            break;
                        }
                    case 5:
                        {
                            string location;
                            location = Console.ReadLine();
                            place.setType(location);
                            Console.WriteLine("Done!");
                            break;
                        }
                    case 6:
                        {
                            double size;
                            size = Double.Parse(Console.ReadLine());
                            place.setSize(size);
                            Console.WriteLine("Done!");
                            break;
                        }
                    case 7:
                        {
                            place.showInfo();
                            break;
                        }
                    case 8:
                        {
                            stop = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Вы ввели что-то не правильно");
                            break;
                        }
                }
            }
        }
    }
}

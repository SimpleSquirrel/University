using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB7EX2
{
    class Student
    {
        private string name;
        private string surname;
        private string adress;
        private string passport;
        private int age;
        private string telephone;
        private int rating;

        public Student()
        {
            name = "Name";
            surname = "Surname";
            adress = "???";
            passport = "???";
            age = 0;
            telephone = "380 000 00 00";
            rating = 0;
        }

        public Student(string name, string surname, string adress, string passport, int age, string telephone, int rating)
        {
            this.name = name;
            this.surname = surname;
            this.adress = adress;
            this.passport = passport;
            this.age = age;
            this.telephone = telephone;
            this.rating = rating;
        }

        public string getName()
        {
            return this.name;
        }
        public string getSurname()
        {
            return this.surname;
        }
        public string getAdress()
        {
            return this.adress;
        }
        public string getPassport()
        {
            return this.passport;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getTelephone()
        {
            return this.telephone;
        }
        public int getRating()
        {
            return this.rating;
        }
    }
}
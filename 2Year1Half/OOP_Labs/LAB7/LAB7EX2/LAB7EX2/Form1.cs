using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB7EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            string surname;
            string adress;
            string passport;
            int age;
            string telephone;
            int rating;
            name = textBox1.Text;
            surname = textBox2.Text;
            adress = textBox3.Text;
            passport = textBox4.Text;
            age = Int32.Parse(textBox5.Text);
            telephone = textBox6.Text;
            rating = Int32.Parse(textBox7.Text);
            Student student = new Student(name, surname, adress, passport, age, telephone, rating);

            string[] XX = File.ReadAllLines("W:/ООП/LAB7/LAB7EX2/students.txt", Encoding.GetEncoding(1251));
            string[] AS = new string[XX.Length + 1];
            for (int i = 0; i < XX.Length; i++)
            {
                AS[i] = XX[i];
            }
            Console.WriteLine("DONE!");
            AS[AS.Length - 1] += (name + "\t" +
                surname + "\t" +
                adress + "\t" +
                passport + "\t" +
                age.ToString() + "\t" +
                telephone + "\t" +
                rating.ToString());

            for (int i = 0; i < AS.Length; i++)
            {
                string[] str1 = AS[i].Split('\t');
                for (int j = 0; j < AS.Length - 1; j++)
                {
                    string[] str2 = AS[j].Split('\t');
                    if (Int32.Parse(str2[6]) > Int32.Parse(str1[6]))
                    {
                        string save = AS[j];
                        AS[j] = AS[i];
                        AS[i] = save;
                    }
                }
            }

            FileStream f = new FileStream("W:/ООП/LAB7/LAB7EX2/students.txt", FileMode.Open);
            StreamWriter wstream = new StreamWriter(f);

            f.Seek(0, SeekOrigin.Current);
            for (int i = 0; i < AS.Length; i++)
            {
                wstream.WriteLine(AS[i]);
            }
            wstream.Close();

            textBox1.Clear();textBox2.Clear();textBox3.Clear();textBox4.Clear();
            textBox5.Clear();textBox6.Clear();textBox7.Clear();
            MessageBox.Show("Я сделяль");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

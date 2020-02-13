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

namespace LAB6EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text, surname = textBox2.Text, birthday = textBox3.Text;
            Console.WriteLine(name,surname,birthday);
            FileStream fstream = new FileStream("W:/ООП/LAB6/LAB6EX2/info.txt", FileMode.OpenOrCreate);
            StreamWriter wstream = new StreamWriter(fstream);
            fstream.Seek(0, SeekOrigin.End);
            wstream.WriteLine(name + "\t" + surname + "\t" + birthday);
            textBox1.Clear();   textBox2.Clear();   textBox3.Clear();
            MessageBox.Show("Done!");
            wstream.Close();
        }
    }
}

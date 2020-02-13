using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB6EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StreamReader reader = new StreamReader("W:/ООП/LAB6/LAB6EX3/text.txt");
            string[] line = reader.ReadLine().Split(' ');
            for(int i = 0; i<line.Length-1; i++)
            {
                for(int j = i+1; j<line.Length-1;j++)
                {
                    if (line[i].Equals(line[j]))
                        line[j] = "";
                }
            }
            for(int i = 0; i < line.Length;i++)
            {
                if (!line[i].Equals(""))
                    richTextBox1.Text += line[i] + "\n";
            }
        }
    }
}

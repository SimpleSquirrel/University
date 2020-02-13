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

namespace RAND1311EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader f = new StreamReader("input.txt");
                string buf;

                while ((buf = f.ReadLine()) != null)  // чтение из файла
                    listBox1.Items.Add(buf);           // занесение в список
            }

            catch (FileNotFoundException exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("output.txt");

            foreach (string item in listBox1.SelectedItems)
                f.WriteLine(item);                          // запись в файл
            f.Close();
        }
    }
}

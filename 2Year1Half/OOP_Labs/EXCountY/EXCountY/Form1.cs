using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShitLib;

namespace EXCountY
{
    public partial class Form1 : Form
    {
        int[] mas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] nums = textBox1.Text.Split(' ');
            mas = new int[nums.Length];
            foreach (string a in nums)
            {
              
                mas[i] = Int32.Parse(nums[i]);i++;
            }
            Array.Sort(mas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for(int i = 0;i<mas.Length-1;i++)
            {
                if (i == mas.Length - 2 && mas[i] != mas[i + 1])
                    richTextBox1.Text += mas[i].ToString() + mas[i + 1].ToString();
                else if (mas[i] != mas[i + 1])
                    richTextBox1.Text += mas[i];
               

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(button1.Text == "Старт")
            {
                timer1.Enabled = true;
                button1.Text = "Стоп";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "Старт";
            }

        }
        public static int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string typingText = "Bla-bla-bla";
            TextChanged.Text = typingText.Substring(0, counter);
            counter++;

            if (counter > typingText.Length)
                counter = 0;
        }
    }
}

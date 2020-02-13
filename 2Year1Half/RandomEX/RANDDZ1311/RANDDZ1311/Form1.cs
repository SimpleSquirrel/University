using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RANDDZ1311
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float x = 5;
        float y = 5;
        float _offset = 5f;
        float _topset = 0f;
        bool right = true;
        bool top = true;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawEllipse(new Pen(Color.Red, 3),x,y,50,50);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            if (x > pictureBox1.Width - 50)
                right = false;
            else if (x <= 0)
                right = true;
            if (right == true)
                x += _offset;
            else
                x -= _offset;

            if (y > pictureBox1.Height - 50)
                top = true;
            else if (y <= 0)
                top = false;
            if (top == true)
                y -= _topset;
            else
                y += _topset;
                g.DrawEllipse(new Pen(Color.Red, 2), x, y, 50, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval += 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 10)
                timer1.Interval -= 10;
            else
                timer1.Interval = 10;
        }

        private void gotop_Click(object sender, EventArgs e)
        {
            if(_topset!=0)
            _topset--;
        }

        private void gobot_Click(object sender, EventArgs e)
        {
            _topset++;
        }
    }
}

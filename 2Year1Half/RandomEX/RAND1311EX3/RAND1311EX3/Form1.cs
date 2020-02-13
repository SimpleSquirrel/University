using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAND1311EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)                           // 1
            {
                using (Pen pen = new Pen(Color.Red))                // 2
                {
                    g.DrawLine(pen, 0, 0, 200, 100);
                    g.DrawEllipse(pen, new Rectangle(50, 50, 100, 150));
                }
                string s = "Sample Text";
                Font font = new Font("Arial", 18);                // 3
                SolidBrush brush = new SolidBrush(Color.Black);   // 4
                float x = 100.0F;
                float y = 20.0F;
                g.DrawString(s, font, brush, x, y);
                font.Dispose();                                     // 5
                brush.Dispose();                                    // 6
            }
        }
    }
}
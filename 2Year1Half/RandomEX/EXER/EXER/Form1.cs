using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int _D;
        private double _OffSet = 0;
        private double n = 0;
        private double r = 0;
        private bool rot = true;
        private double speed = 51;
        private int ghost = 15;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") ||
                Int32.Parse(textBox1.Text) < 3 ||
                Int32.Parse(textBox1.Text) > 180 ||
                Int32.Parse(textBox2.Text) <= 0 ||
                ( (2 * Double.Parse(textBox2.Text) * Math.Sin(Math.PI / Double.Parse(textBox1.Text))) 
                * Double.Parse(textBox1.Text)) > 170)
            {
                MessageBox.Show("Вы ввели что-то непрвильно, либо параметры слишком большие");
                textBox1.Clear();
                textBox2.Clear();
                label4.Text = "";
            }
            else
            {
                timer1.Enabled = false;
                n = Double.Parse(textBox1.Text);
                r = Double.Parse(textBox2.Text);
                double side = 2 * r * Math.Sin(Math.PI / n);
                double P = side * n;
                _D = (int)side*10;
                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.Black);
                label4.Text = P.ToString();

                List<Point> p = new List<Point>();
                _D = (int)(r * 10);
                for (int i = 0; i < 360; i += 180 / (int)n * 2) //i градусы между сторонами
                {
                    var kr = _D / 2;
                    double rad = (double)i / 180.0 * Math.PI;
                    int x = (int)(kr * Math.Cos(rad + _OffSet));
                    int y = (int)(kr * Math.Sin(rad + _OffSet));

                    p.Add(new Point(x + kr, y + kr));
                }
                g.DrawEllipse(Pens.Red, new Rectangle(new Point(), new Size(_D, _D)));
                g.DrawPolygon(new Pen(Color.FromArgb(255,
                                                     255,
                                                     255,
                                                     255)),
                                                     p.ToArray());
                if (move == true)
                {
                    rotate(r, n, _OffSet);
                    timer1.Enabled = true;
                }
                else
                {
                    timer1.Enabled = false;
                }
            }   
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && 
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar!='.')
            {
                e.Handled = true;
            }

            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.')>-1))
                {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void rotate(double r, double n, double _OffSet)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.Black);
            Random rand = new Random();
            if (rot)
            {
                for (int j = 1; j < ghost; j++)
                {
                    _OffSet -= 0.05 / speed * 40;
                    List<Point> p = new List<Point>();
                    _D = (int)(r * 10);
                    for (int i = 0; i < 360; i += 180 / (int)n * 2) //i градусы между сторонами
                    {
                        var kr = _D / 2;
                        double rad = (double)i / 180.0 * Math.PI;
                        int x = (int)(kr * Math.Cos(rad + _OffSet));
                        int y = (int)(kr * Math.Sin(rad + _OffSet));

                        p.Add(new Point(x + kr, y + kr));
                    }
                    g.DrawEllipse(Pens.Red, new Rectangle(new Point(), new Size(_D, _D)));
                    g.DrawPolygon(new Pen(Color.FromArgb(255 / ((j/2)+1),
                                                         255,
                                                         255,
                                                         255)),
                                                         p.ToArray());
                }
            }
            else
            {
                for (int j = 1; j < ghost; j++)
                {
                    _OffSet += 0.05 / speed * 40;
                    List<Point> p = new List<Point>();
                    _D = (int)(r * 10);
                    for (int i = 0; i < 360; i += 180 / (int)n * 2) //i градусы между сторонами
                    {
                        var kr = _D / 2;
                        double rad = (double)i / 180.0 * Math.PI;
                        int x = (int)(kr * Math.Cos(rad + _OffSet));
                        int y = (int)(kr * Math.Sin(rad + _OffSet));

                        p.Add(new Point(x + kr, y + kr));
                    }
                    g.DrawEllipse(Pens.Red, new Rectangle(new Point(), new Size(_D, _D)));
                    g.DrawPolygon(new Pen(Color.FromArgb(255 / ((j/2)+1),
                                                         255,
                                                         255,
                                                         255)),
                                                         p.ToArray());
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (move == true)
            {
                if (rot == true)
                {
                    _OffSet += Math.PI / speed;
                    rotate(r, n, _OffSet);
                }
                else
                {
                    _OffSet -= Math.PI / speed;
                    rotate(r, n, _OffSet);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rot = !rot;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (speed == 1)
            {
                MessageBox.Show("Это максимальная скорость, её стоило бы понизить");
            }
            else
            {
                if (speed == 51)
                    ghost = 15;
                ghost--;
                speed -= 10;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (speed > 100)
            {
                MessageBox.Show("Скорость практически = 0, повысьте её");
            }
            else
            {
                if (ghost < 20)
                    ghost++;
                speed += 10;
            }
        }

        private bool move = false;
        private void button5_Click(object sender, EventArgs e)
        {

            if (move == false)
                button5.Text = "Stop";
            else
                button5.Text = "Start";

                move = !move;
        }
    }
}

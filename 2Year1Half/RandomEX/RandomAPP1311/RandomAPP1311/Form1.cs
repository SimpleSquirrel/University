using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomAPP1311
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arr;
        private void createbutton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = -10, b = 10;             // диапазон значений элементов
            if (radioButton2.Checked)
            {
                a = -100; b = 100;                // корректировка диапазона
            }

            int n = 0;
            try
            {
                n = int.Parse(numtextBox.Text);             // длина массива
            }
            catch
            {
                MessageBox.Show("Введите количество элементов!");
                numtextBox.Clear();
                numtextBox.Focus();
            }

            arraytextBox.Clear();                     // очистка полей ввода
            maxtextBox.Clear();
            numPosittextBox.Clear();

            if (n < 0) n = -n;         // если введено отрицательное число
            arr = new int[n];                            // создание массива
            for (int i = 0; i < n; ++i)
            {
                arr[i] = rnd.Next(a, b);         // задание элемента массива
                arraytextBox.Text += "  " + arr[i];         // вывод массива
            }
        }

        private void calcbutton_Click(object sender, EventArgs e)
        {
            int max = arr[0];
            int numPosit = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > max) max = arr[i];         // поиск максимума
                if (arr[i] > 0) ++numPosit;      // кол-во положительных
            }
            if (maxcheckBox.Checked)
                maxtextBox.Text = max.ToString();
            else maxtextBox.Text = "";
            if (numPositcheckBox.Checked)
                numPosittextBox.Text = numPosit.ToString();
            else numPosittextBox.Text = "";

        }

        private void maxtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numPositcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.MaltsevVS.WindowsForm.Lab8.V0
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

        private void textBox_Y_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_X.Text, out double x) && double.TryParse(textBox_Y.Text, out double y))
            {
                if (SolveExpress_2_1.Checked)
                {
                    double res = Math.Log(Math.Abs((y - Math.Sqrt(Math.Abs(x))) * (x - (y / (x + (x * x / 4))))));
                    res = Math.Round(res, 3);
                    textBox_result.Text = res.ToString();
                }
                else if (SolveExpress_2_2.Checked)
                {
                    double res = Math.Pow(2, -x) + (5 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3)) - Math.Cos(Math.Pow(x, 2)) + Math.Sin(2 * x * y);
                    res = Math.Round(res, 3);
                    textBox_result.Text = res.ToString();
                }
            }
            else
            {
                MessageBox.Show("Введите корректные значения для x и y");
            }
        }

        private void textBox_X_TextChanged(object sender, EventArgs e)
        {

        }

        private void SolveExpress_2_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SolveExpress_2_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

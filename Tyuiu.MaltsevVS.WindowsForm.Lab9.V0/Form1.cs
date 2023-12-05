using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.MaltsevVS.WindowsForm.Lab9.V0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox_X1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_X2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_result_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_X1.Text, out int x1) && int.TryParse(textBox_X2.Text, out int x2))
            {
                GenerateTableAndChart(x1, x2);
            }
            else
            {
                MessageBox.Show("Введите корректные значения для X1 и X2");
            }
        }

        private void dataGridView_res_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart_res_Click(object sender, EventArgs e)
        {

        }


        private void GenerateTableAndChart(int startValue, int stopValue)
        {
            double[] valueArray = GetMassFunction(startValue, stopValue);

            dataGridView_res.Rows.Clear();
            dataGridView_res.Columns.Clear();

            dataGridView_res.Columns.Add("ColumnX", "X");
            dataGridView_res.Columns.Add("ColumnY", "Y");

            chart_res.Series[0].Points.Clear();
            chart_res.Series[0].ChartType = SeriesChartType.Line;

            for (int i = 0; i < valueArray.Length; i++)
            {
                dataGridView_res.Rows.Add(startValue + i, valueArray[i]);
                chart_res.Series[0].Points.AddXY(startValue + i, valueArray[i]);
            }
        }

        private double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Pow(x, 3) - 15 * x) != 0)
                {
                    y = Math.Sin(Math.Sqrt(x * x)) + Math.Cos(x * x) / (3 * (x * x * x)) - Math.Sin(Math.Sqrt(x * x - 1));
                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    valueArray[count] = 0;
                    count++;
                }
            }

            return valueArray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

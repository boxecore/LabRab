using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MaltsevVS.ConsoleApp.Lab2.V0.Lib
{
    public class DataService
    {
        public double SolveExpress_2_1(double x, double y)
        {
            double res = Math.Log(Math.Abs((y - Math.Sqrt(Math.Abs(x))) * (x - (y / (x + (x * x / 4))))));
            return res;
        }
        public double SolveExpress_2_2(double x, double y)
        {
            double res = Math.Pow(2, -x) + (5 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3)) - Math.Cos(Math.Pow(x, 2)) + Math.Sin(2 * x * y);
            return res;
        }
    }
}
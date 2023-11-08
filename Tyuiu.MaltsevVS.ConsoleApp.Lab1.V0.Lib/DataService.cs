using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MaltsevVS.ConsoleApp.Lab1.V0.Lib
{
    public class DataService
    {
        public double SolveExpress_1_1(double x, double y, double a)
        {
            double res = 3 * x - (3 * x + a - 4 * a) / (3 * a + 2 * x + 6 * y) + (((a * x / y) + a / 2) / (3 * a / x)) + 2 * x;
            return res;
        }
        public double SolveExpress_1_2(double x, double y, double a)
        {
            double res = 4 * x + ((2 + y + x - 3 * y) / (x - 7 * y)) - ((y / y) / (3 * y / x));
            return res;
        }

    }
}

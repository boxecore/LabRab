namespace Tyuiu.MaltsevVS.ConsoleApp.Lab5.V0.Lib
{
    using System;

    public class SequenceCalculator
    {
        public static double CalculateSum(int N)
        {
            double sum = 0;
            for (int x = 1; x <= N; x++)
            {
                double term = Math.Sin(Math.Sqrt(x * x)) + (Math.Cos(x * x) / (3 * Math.Pow(x, 3)));
                sum += term;
            }
            return sum;
        }
    }

}
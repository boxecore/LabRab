using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MaltsevVS.ConsoleApp.Lab6.V0.Lib
{
    public class DataService
    {
         public double [] GetMassFunction (int startValue, int stopValue)

        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x<=stopValue; x++)
            {
                if((Math.Pow(x, 3) - 15 * x) !=0)
                {
                    y = Math.Sin(Math.Sqrt(x * x)) + Math.Cos(x * x) / (3 * (x * x * x)) - Math.Sin(Math.Sqrt(x * x - 1));


                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    
                    count++;
                }
               
            }
            return valueArray;
        }
    }
}
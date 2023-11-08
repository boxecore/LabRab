using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MaltsevVS.ConsoleApp.Lab1.V0.Lib;

namespace Tyuiu.MaltsevVS.ConsoleApp.Lab1.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа №1                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Мальцев Вадим Степанович | НТм-22-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, для расчета арифметических         *");
            Console.WriteLine("* выражений.                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 6;
            double y = 4;
            double a = 8;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("a = " + a);

            DataService ds = new DataService();

            double res_1_1 = ds.SolveExpress_1_1(x, y, a);
            res_1_1 = Math.Round(res_1_1, 1);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ_1_1:                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res_1_1);

            double res_1_2 = ds.SolveExpress_1_2(x, y, a);
            res_1_2 = Math.Round(res_1_2, 1);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ_1_2:                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res_1_2);

            Console.ReadKey();

        }
    }
}

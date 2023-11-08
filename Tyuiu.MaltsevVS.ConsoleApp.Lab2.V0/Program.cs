using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MaltsevVS.ConsoleApp.Lab2.V0.Lib;

namespace Tyuiu.MaltsevVS.ConsoleApp.Lab2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа №2                                                  *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Мальцев Вадим Степанович | НТм-22-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, для расчёта математичских          *");
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

            double res_2_1 = ds.SolveExpress_2_1(x, y);
            res_2_1 = Math.Round(res_2_1, 3);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ_2_1:                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res_2_1);

            double res_2_2 = ds.SolveExpress_2_2(x, y);
            res_2_2 = Math.Round(res_2_2, 3);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ_2_2:                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res_2_2);

            Console.ReadKey();

        }
    }
}
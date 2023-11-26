using System;

using Tyuiu.MaltsevVS.ConsoleApp.Lab6.V0.Lib;
namespace Tyuiu.MaltsevVS.ConsoleApp.Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа №6                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Мальцев Вадим Степанович | НТм-22-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу, которая запрашивает значения  N          *");
            Console.WriteLine("* с клавиатуры и вычисляет сумму числовой последовательности по формуле.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("+-----------------------+");
            Console.WriteLine("|    X     |    f(x)    |");
            Console.WriteLine("+-----------------------+");

            for (int i = 0; i < len; i++)
            {
                if ((3 * (startValue * startValue * startValue) - 15 * startValue) == 0)
                {
                    Console.WriteLine("Деление на " + valueArray[i] + " невозможно");
                }
                else
                {
                    Console.WriteLine("|{0,5:d}     |   {1,6:f3}   |", startValue, valueArray[i]);
                }
                startValue++;
            }
            Console.WriteLine("+-----------------------+");
            Console.ReadKey();
        }
    }
}

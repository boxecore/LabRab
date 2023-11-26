using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MaltsevVS.ConsoleApp.Lab3.V3.Lib;
namespace Tyuiu.MaltsevVS.ConsoleApp.Lab3.V3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            bool res;

            int x;
            int y;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа №3                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Мальцев Вадим Степанович | НТм-22-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая запрашивает целые значения *");
            Console.WriteLine("* с клавиатуры и вычисляет находится ли точка с координатами Х,У заш.обл. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значения переменной x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значения переменной y: ");
            y = Convert.ToInt32(Console.ReadLine());

            res = ds.GetPointShape(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в границах фигуры");
            }

            else
            {
                Console.WriteLine("Точка находится за пределами границ фигуры");
            }

            Console.ReadKey();
        }
    }
}
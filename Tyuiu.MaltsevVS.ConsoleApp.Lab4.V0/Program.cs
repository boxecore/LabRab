using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MaltsevVS.ConsoleApp.Lab4.V0.Lib;
namespace Tyuiu.MaltsevVS.ConsoleApp.Lab4.V0;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Лабораторная работа №4                                                  *");
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

        Console.Write("Введите координату X: ");
        
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        bool isInsideShadedArea = ShadedAreaCalculator.IsInsideShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (isInsideShadedArea)
            Console.WriteLine("Точка находится внутри заштрихованной области.");
        else
            Console.WriteLine("Точка находится вне заштрихованной области.");

        Console.ReadLine();
    }
}
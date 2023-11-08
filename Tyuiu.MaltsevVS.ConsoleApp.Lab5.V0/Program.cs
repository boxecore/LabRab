using System;
using Tyuiu.MaltsevVS.ConsoleApp.Lab5.V0.Lib;
class Program
{
    static void Main()
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Лабораторная работа №5                                                  *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Мальцев Вадим Степанович | НТм-22-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу, которая запрашивает значения  N          *");
        Console.WriteLine("* с клавиатуры и вычисляет сумму числовой последовательности по формуле.  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение N: ");
        if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
        {
            double sum = SequenceCalculator.CalculateSum(N);
            Console.WriteLine("Сумма последовательности S = " + sum);
        }
        else
        {
            Console.WriteLine("Введите положительное целое число для N.");
        }
    }
}


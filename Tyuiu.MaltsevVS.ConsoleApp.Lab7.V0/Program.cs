using System;

using Tyuiu.MaltsevVS.ConsoleApp.Lab7.V0.Lib;
namespace Tyuiu.MaltsevVS.ConsoleApp.Lab7;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите начало диапазона чисел в массиве: ");
        int startRange = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите конец диапазона чисел в массиве: ");
        int endRange = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[arrayLength];
        Random random = new Random();

        for (int i = 0; i < arrayLength; i++)
        {
            numbers[i] = random.Next(startRange, endRange + 1);
        }

        Console.Write("Введите число, наличие которого в массиве вы хотите проверить: ");
        int targetNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Массив:");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        ArrayAnalyzer analyzer = new ArrayAnalyzer(numbers);

        analyzer.PrintAnalysis();

        Console.WriteLine($"Число {targetNumber} находится в массиве: {analyzer.CountOccurrences(targetNumber)} раз");
    }
}

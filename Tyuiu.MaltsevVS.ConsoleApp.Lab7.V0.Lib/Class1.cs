namespace Tyuiu.MaltsevVS.ConsoleApp.Lab7.V0.Lib
{
    public class ArrayAnalyzer
    {
        private int[] numbers;

        public ArrayAnalyzer(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int CountOccurrences(int targetNumber)
        {
            int count = 0;
            foreach (var num in numbers)
            {
                if (num == targetNumber)
                {
                    count++;
                }
            }
            return count;
        }

        public void PrintAnalysis()
        {
            int negativeCount = 0;
            int positiveCount = 0;
            int evenCount = 0;
            int oddCount = 0;
            int sum = 0;
            int min = int.MaxValue;

            foreach (var num in numbers)
            {
                if (num < 0)
                {
                    negativeCount++;
                }
                else if (num > 0)
                {
                    positiveCount++;
                }

                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

                sum += num;

                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine($"Количество отрицательных элементов: {negativeCount}");
            Console.WriteLine($"Количество положительных элементов: {positiveCount}");
            Console.WriteLine($"Количество четных элементов: {evenCount}");
            Console.WriteLine($"Количество нечетных элементов: {oddCount}");
            Console.WriteLine($"Среднее значение элементов массива равно: {(double)sum / numbers.Length}");
            Console.WriteLine($"Минимальное значение элементов массива равно: {min}");
        }
    }

}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaltsevVS.ConsoleApp.Lab7.V0.Lib;

namespace Tyuiu.MaltsevVS.ConsoleApp.Lab7.V0.Test

{
    [TestClass]
    public class ArrayAnalyzerTests
    {
        [TestMethod]
        public void CountOccurrences_ShouldReturnCorrectCount()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 2, 2, 6 };
            ArrayAnalyzer analyzer = new ArrayAnalyzer(numbers);

            int targetNumber = 2;
            int expectedCount = 3;

            int actualCount = analyzer.CountOccurrences(targetNumber);

            Assert.AreEqual(expectedCount, actualCount, "CountOccurrences method is not working correctly.");
        }
    }
}


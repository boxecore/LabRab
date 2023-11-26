using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaltsevVS.ConsoleApp.Lab6.V0.Lib;

namespace Tyuiu.MaltsevVS.ConsoleApp.Lab6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateMassFunction_ValidInput_ExpectedResult()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray = { 0.021, -0.084, -0.156, -0.050, 0.661, 0, 1.022, -0.105, -0.178, -0.094, 0.026 };

            double[] res = ds.GetMassFunction(startValue, stopValue);

            for (int i = 0; i < len; i++)
            {
                valueWaitArray[i] = Math.Round(valueWaitArray[i], 3);
            }

            for (int i = 0; i < len; i++)
            {
                res[i] = Math.Round(res[i], 3);
            }

            Console.WriteLine("Expected Array:");
            foreach (var value in valueWaitArray)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("Actual Array:");
            foreach (var value in res)
            {
                Console.WriteLine(value);
            }
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaltsevVS.ConsoleApp.Lab4.V0.Lib;

namespace Tyuiu.MaltsevVS.ConsoleApp.Lab4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetPoint_1()
        {
            double x = 0.2;
            double y = 0.2;

            bool res = ShadedAreaCalculator.IsInsideShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }
        public void ValidGetPoint_2()
        {
            double x = -0.2;
            double y = 0.2;

            bool res = ShadedAreaCalculator.IsInsideShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
        public void ValidGetPoint_3()
        {
            double x = 0;
            double y = 0;

            bool res = ShadedAreaCalculator.IsInsideShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}

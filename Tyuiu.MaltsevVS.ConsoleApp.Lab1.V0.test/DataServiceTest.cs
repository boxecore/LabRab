using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MaltsevVS.ConsoleApp.Lab1.V0.Lib;


namespace Tyuiu.MaltsevVS.ConsoleApp.Lab1.V0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExsprecion_1_1()
        {
            double x = 6;
            double y = 4;
            double a = 8;
            DataService ds = new DataService();

            double res = ds.SolveExpress_1_1(x, y, a);

            res = Math.Round(res, 1);
            double wait = 34.1;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExsprecion_1_2()
        {
            double x = 10;
            double y = 10;
            double a = 10;
            DataService ds = new DataService();

            double res = ds.SolveExpress_1_2(x, y, a);

            res = Math.Round(res, 1);
            double wait = 39.8;

            Assert.AreEqual(wait, res);
        }

    }
}

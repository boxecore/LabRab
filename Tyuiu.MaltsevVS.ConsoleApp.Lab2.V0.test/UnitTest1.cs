using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MaltsevVS.ConsoleApp.Lab2.V0.Lib;


namespace Tyuiu.MaltsevVS.ConsoleApp.Lab2.V0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExsprecion_2_1()
        {
            double x = 5;
            double y = 10;
            DataService ds = new DataService();

            double res = ds.SolveExpress_2_1(x, y);

            res = Math.Round(res, 3);
            double wait = 3.463;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExsprecion_2_2()
        {
            double x = 6;
            double y = 10;
            DataService ds = new DataService();

            double res = ds.SolveExpress_2_2(x, y);

            res = Math.Round(res, 3);
            double wait = 1.002;

            Assert.AreEqual(wait, res);
        }

    }
}

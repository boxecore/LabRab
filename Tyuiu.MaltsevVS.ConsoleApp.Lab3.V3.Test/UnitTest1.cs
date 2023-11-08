using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MaltsevVS.ConsoleApp.Lab3.V3.Lib;

namespace Tyuiu.MaltsevVS.ConsoleApp.Lab3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetPoint()
        {
            DataService ds = new DataService();

            int x = 1;
            int y = 1;

            bool res = ds.GetPointShape(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}
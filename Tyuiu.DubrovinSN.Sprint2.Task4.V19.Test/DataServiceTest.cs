using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint2.Task4.V19.Lib;

namespace Tyuiu.DubrovinSN.Sprint2.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 0.911;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 7;
            double res = ds.Calculate(x, y);
            double wait = 6.082;
            Assert.AreEqual(wait, res);
        }
    }
}

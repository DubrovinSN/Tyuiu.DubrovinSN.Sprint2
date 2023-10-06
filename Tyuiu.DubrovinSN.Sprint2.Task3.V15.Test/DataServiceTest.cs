using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint2.Task3.V15.Lib;

namespace Tyuiu.DubrovinSN.Sprint2.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 11;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 256;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            double wait = -219.95;
            Assert.AreEqual(wait, res);
        }
    }
}

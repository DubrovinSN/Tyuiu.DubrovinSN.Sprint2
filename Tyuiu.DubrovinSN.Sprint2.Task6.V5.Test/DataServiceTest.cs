using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint2.Task6.V5.Lib;

namespace Tyuiu.DubrovinSN.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 14;
            string res = ds.FindCardValue(value);
            Assert.AreEqual(res, "Туз");
        }
    }
}

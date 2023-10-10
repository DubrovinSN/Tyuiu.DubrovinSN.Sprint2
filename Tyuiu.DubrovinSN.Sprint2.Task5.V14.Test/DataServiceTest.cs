using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint2.Task5.V14.Lib;

namespace Tyuiu.DubrovinSN.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 14;
            string res = ds.FindDayName(value);
            Assert.AreEqual(res, "Воскресенье");
        }
    }
}

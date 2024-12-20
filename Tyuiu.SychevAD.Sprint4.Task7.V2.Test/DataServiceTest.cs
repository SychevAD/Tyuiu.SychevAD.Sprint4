using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SychevAD.Sprint4.Task7.V2.Lib;

namespace Tyuiu.SychevAD.Sprint4.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string str = "597643158942";
            int rows = 4, columns = 3;
            int[,] ints = new int[rows, columns];
            int res = dataService.Calculate(rows, columns, str), wait = 39;
            Assert.AreEqual(wait, res);
        }
    }
}
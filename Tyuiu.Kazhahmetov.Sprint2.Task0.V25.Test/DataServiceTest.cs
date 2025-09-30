﻿using Tyuiu.Kazhahmetov.Sprint2.Task0.Lib;
namespace Tyuiu.Kazhahmetov.Sprint2.Task0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 205;
            int y = 159;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, true, true, false, false, false };
            CollectionAssert.AreEqual(res, wait);
        }

    }
}

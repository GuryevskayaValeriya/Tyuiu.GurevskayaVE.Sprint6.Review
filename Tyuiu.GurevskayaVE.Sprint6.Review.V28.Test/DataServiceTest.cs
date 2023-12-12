using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GurevskayaVE.Sprint6.Review.V28.Lib;

namespace Tyuiu.GurevskayaVE.Sprint6.Review.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] { { -4, -3, -2, -1, 0 }, 
                                         { 1, 2, 3, 4, 0 }, 
                                         { -4, -3, -2, -1, 0 }, 
                                         { 1, 2, 3, 4, 0 }, 
                                         { -4, -3, -2, -1, 0 } };
            double res = ds.GetMatrix(mas, -4, 5, 1, 1, 2);
            double wait = -0.6;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetMatrix1()
        {
            DataService ds = new DataService();
            int[,] arr = new int[3, 4] { { 1, 2, 3, 5 },
                                         { 1, 2, 4, 5 },
                                         { 3, 4, 5, 5 } };
            double res = ds.GetMatrix(arr, 1, 6, 0, 1, 2);
            double wait = 2.917;
            Assert.AreEqual(wait, res);

        }
    }
}

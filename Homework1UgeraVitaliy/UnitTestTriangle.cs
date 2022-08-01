using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework10;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void Distance_AandB_returnDistance()
        {
            Point a = new Point(0, 0);
            Point b = new Point(0, 2);
            Point c = new Point(0, 1);

            Triangle triangle = new Triangle(a, b, c);

            double expected1 = 2;
            double expected2 = 1;
            double expected3 = 1;

            double actual1 = triangle.DistanceBetweenTwoPoints(a, b);
            double actual2 = triangle.DistanceBetweenTwoPoints(b, c);
            double actual3 = triangle.DistanceBetweenTwoPoints(a, c);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
        [TestMethod]
        public void Perimeter_AplusBplusC_returnZero()
        {
            Point a = new Point(0, 0);
            Point b = new Point(0, 2);
            Point c = new Point(0, 1);

            Triangle triangle = new Triangle(a, b, c);

            double expected = 0;

            double actual = triangle.Perimeter();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Perimeter_AplusBplusC_returnSum()
        {
            Point a = new Point(0, 0);
            Point b = new Point(1, 0);
            Point c = new Point(0, 1);

            Triangle triangle = new Triangle(a, b, c);

            double expected = Math.Sqrt(2) + 2;

            double actual = triangle.Perimeter();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Area_AandBandC_returnHeronFormulaResult()
        {
            Point a = new Point(0, 0);
            Point b = new Point(1, 0);
            Point c = new Point(0, 1);

            Triangle triangle = new Triangle(a, b, c);
            double halfAPer = (double)triangle.Perimeter() / 2;
            double expected = Math.Sqrt(halfAPer*(halfAPer - 1)*(halfAPer - 1)*(halfAPer - Math.Sqrt(2)));

            double actual = triangle.Area();

            Assert.AreEqual(expected, actual);
        }
    }
}

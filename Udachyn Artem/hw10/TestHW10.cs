using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task_hw10;

namespace TestHW10
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Distance()
        {
            Point p1 = new Point(0, 1);
            Point p2 = new Point(1, -1);
            double expected = 2.236;
            double actual = p1.Distance(p2);
            string s = p1.ToString();
            Assert.AreEqual(expected, Math.Round(actual, 3));
            Assert.AreEqual($"x: {p1.X}, y: {p1.Y}", s);
        }
        [TestMethod]
        public void Perimetr()
        {
            Triangle triangle = new Triangle(new Point(20, 11), new Point(11, 45), new Point(45, 20));
            double expected = 103.944;
            double actual = triangle.Perimetr();
            Assert.AreEqual(expected, Math.Round(actual, 3));
        }
        [TestMethod]
        public void Area()
        {
            Triangle triangle = new Triangle(new Point(7, 16), new Point(16, -10), new Point(-10, 7));
            double expected = 261.5;
            double actual = triangle.Square();
            Assert.AreEqual(expected, Math.Round(actual, 3));
        }

    }
}

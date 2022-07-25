using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Homework_10;

namespace UnitTestTriangle
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void Point_ToString_x6y7_bkt6c_7bkt()
        {
            //Arrange
            double x = 6;
            double y = 7;
            string expected = "(6, 7)";

            //Actual
            Point testPoint = new Point(x, y);
            string actual = testPoint.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class TriangleTest
    { 
        [TestMethod]
        public void Distance_pointA8с9_pointB9с10_1с41()
        {
            //Arrange
            Point pointA = new Point(8, 9);
            Point pointB = new Point(9, 10);
            double expected = 1.41;

            //Actual
            Point pointC = new Point(10, 11);
            Triangle triangle = new Triangle(pointA, pointB, pointC);
            double actual = triangle.Distance(pointA, pointB);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Perimeter_pointA3c8_pointB8c5_pointC6c4_13c07()
        {
            //Arrange
            Point pointA = new Point(3, 8);
            Point pointB = new Point(8, 5);
            Point pointC = new Point(6, 4);
            double expected = 13.07; //5.83+2.24+5=13.07

            //Actual
            Triangle triangle = new Triangle(pointA, pointB, pointC);
            double actual = triangle.Perimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Square_pointA3c8_pointB8c5_pointC6c4_5c51()
        {
            //Arrange
            Point pointA = new Point(3, 8);
            Point pointB = new Point(8, 5);
            Point pointC = new Point(6, 4);
            double expected = 5.51;

            //Actual
            Triangle triangle = new Triangle(pointA, pointB, pointC);
            double actual = triangle.Square();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinimalDistance_pointA3c8_pointB8c5_pointC6c4_()
        {
            //Arrange
            Point pointA = new Point(3, 8); // 8.54
            Point pointB = new Point(8, 5); // 9.43
            Point pointC = new Point(6, 4); // 7.21
            double expected = 7.21;

            //Actual
            Triangle triangle = new Triangle(pointA, pointB, pointC);
            double actual = triangle.MinimalDistance();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

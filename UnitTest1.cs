using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TriangleSpace;


namespace TriangleTest
{
    [TestClass]
    public class TriangleTestClass
    {
        [TestMethod]
        public void Distance_readPoint1andPoint2_returnDistance()
        {
            Point a = new Point(0, 0);
            Point b = new Point(1,0);
            double expected = 1;
            double actual = Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PerimetrTriangle_readTriangle_returnPerimetr()
        {
            Point a = new Point(0, 0);
            Point b = new Point(10, 0);
            Point c = new Point(0, 10);
            Triangle triangle = new Triangle(a,b,c);
            double expected = 34;
            double actual =Math.Round(triangle.Dictance(triangle.vertex1, triangle.vertex2) + triangle.Dictance(triangle.vertex2, triangle.vertex3) + triangle.Dictance(triangle.vertex1, triangle.vertex3)); 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareTriangle_readTriangle_returnSquare()
        {
            Point a = new Point(0, 0);
            Point b = new Point(10, 0);
            Point c = new Point(0, 10);
            Triangle triangle = new Triangle(a, b, c);
            double expected = 50;
            double actual = Math.Abs((((triangle.vertex2.X - triangle.vertex1.X) * (triangle.vertex3.Y - triangle.vertex1.Y)) -
                             ((triangle.vertex3.X - triangle.vertex1.X) * (triangle.vertex2.Y - triangle.vertex1.Y))) / 2);
            Assert.AreEqual(expected, actual);
        }
    }
}

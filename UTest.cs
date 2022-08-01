using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW10;
namespace TestTriangle
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Distance_X4y5AndX1y1_return5()
        {
            Point A = new Point(4, 5);
            Point B = new Point(1, 1);
            double expected = 5;
            Triangle name = new Triangle(new Point(0, 0), new Point(1, 0), new Point(0, 1));
            double actual = name.Distance(A, B);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Perimeter_X4y5AndX1y1AndX2y2_return10_02()
        {
            Point A = new Point(4, 5);
            Point B = new Point(1, 1);
            Point C = new Point(2, 2);
            double expected = 10.02;
            Triangle name = new Triangle(A, B, C);
            double actual = name.Perimeter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Square_X4y5AndX1y1AndX2y2_return0_5()
        {
            Point A = new Point(4, 5);
            Point B = new Point(1, 1);
            Point C = new Point(2, 2);
            double expected = 0.5;
            Triangle name = new Triangle(A, B, C);
            double actual = name.Square();
            Assert.AreEqual(expected, actual);
        }
         [TestMethod]
        public void Distances_X4y5_X1y1_X2y2()
        {
            Point A = new Point(1, 1);
            Point B = new Point(0, 3);
            Point C = new Point(2, 4);
            List<double> expected = new List<double> { 1.41, 3, 4.47 };
            Triangle triangle = new Triangle(A, B, C);
            List<double> actual = triangle.DistancesToOrigin();
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }  
    }
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void Point_ToString_x6y7_bkt6c_7bkt()
        {
            int x = 1;
            int y = 2;
            string expected = "(1, 2)";
            Point testPoint = new Point(x, y);
            string actual = testPoint.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}

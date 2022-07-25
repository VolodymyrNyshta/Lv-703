namespace HW10_Test_Triangle
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            Point p1, p2, p3;
            p1 = new Point(1, 1);
            p2 = new Point(2, 7);
            p3 = new Point(7, 3);
            Triangle tr1 = new Triangle(p1, p2, p3);

            //Act
            double p = Convert.ToInt32(tr1.Perimetr());

            //Assert
            Assert.AreEqual(18, p);
        }

        [Test]
        public void Test2()
        {
            //Arrange
            Point p1, p2, p3;
            p1 = new Point(1, 1);
            p2 = new Point(2, 7);
            p3 = new Point(7, 3);
            Triangle tr1 = new Triangle(p1, p2, p3);

            //Act
            double s = Convert.ToInt32(tr1.Square());

            //Assert
            Assert.AreEqual(6, s);
        }

        [Test]
        public void Test3()
        {
            //Arrange
            Point p1, p2, p3;
            p1 = new Point(1, 1);
            p2 = new Point(2, 7);
            p3 = new Point(7, 3);
            Triangle tr1 = new Triangle(p1, p2, p3);

            //Act
            double d = Convert.ToInt32(tr1.Vertex1.Distance(tr1.Vertex2));

            //Assert
            Assert.AreEqual(8, d);
        }
    }
}
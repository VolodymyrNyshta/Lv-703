using System.Collections.Generic;

namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> listOfTriangles = new List<Triangle>()
            {
                new Triangle(new Point(1,2), new Point(4,-1), new Point(3,12)),
                new Triangle(new Point(0,3), new Point(2,3), new Point(3,10)),
                new Triangle(new Point(6,0), new Point(2,5), new Point(3,0)),
                new Triangle(new Point(1,-4), new Point(7,2), new Point(2,2)),
                new Triangle(new Point(0,-2), new Point(-7,-1), new Point(1,1))
            };
        }
    }
}

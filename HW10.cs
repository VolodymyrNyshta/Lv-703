using System;
using System.Linq;
using System.Collections.Generic;
namespace HW10
{
    internal class HW10
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(new Point(1, 0), new Point(1, 4), new Point(4, 3)));
            triangles.Add(new Triangle(new Point(1, 0), new Point(1, 4), new Point(4, 4)));
            triangles.Add(new Triangle(new Point(5, 2), new Point(-3, 3), new Point(-5, 0)));
            foreach (Triangle triangle in triangles)
                triangle.Print();

            // Print the triangle with vertex which is the closest to origin (0,0)
            Point origin = new Point(0, 0);

            Dictionary<Triangle, double> result = new Dictionary<Triangle, double>();
            foreach (Triangle triangle in triangles)
                result.Add(triangle, triangle.DistancesToOrigin().Min());
            var nearOrigin = result.OrderBy(x => x.Value).First();
            Console.WriteLine("The triangle with vertex which is the closest to origin: {0}, {1}, {2}.", nearOrigin.Key.Vertex1, nearOrigin.Key.Vertex2, nearOrigin.Key.Vertex3);

        }
    }
}

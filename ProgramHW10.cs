using System;
using System.Collections.Generic;

namespace TriangleSpace
{
   public struct Point
    {
       private int x;
       private int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
        public override string ToString()
        {
            return string.Format($"X:{x}  Y:{y}");
        }
    }

   public class Triangle
    {
        public Point vertex1;
        public Point vertex2;
        public Point vertex3;

        public Triangle(Point a, Point b, Point c)
        {
            vertex1 = a;
            vertex2 = b;
            vertex3 = c;
        }

       public double Dictance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
        }

        public double Perimetr(Triangle triangle)
        {
            return  Dictance(triangle.vertex1, triangle.vertex2) + Dictance(triangle.vertex2, triangle.vertex3) + Dictance(triangle.vertex1, triangle.vertex3);
        }
        public double Square(Triangle triangle)
        {
            return Math.Abs((((triangle.vertex2.X - triangle.vertex1.X) * (triangle.vertex3.Y - triangle.vertex1.Y)) -
                             ((triangle.vertex3.X - triangle.vertex1.X) * (triangle.vertex2.Y - triangle.vertex1.Y))) / 2);
        }

        public void FindCloseToOrigin(List<Triangle> triangles)
        {
            Triangle closerTriangle = null;
            Point closerVertex = triangles[0].vertex1;
            Point origin = new Point(0, 0);
           
            foreach (Triangle triangle in triangles)
            {
                if (Dictance(triangle.vertex1, origin) < Dictance(closerVertex, origin))
                {
                    closerVertex = triangle.vertex1;
                    closerTriangle = triangle;
                }
                if (Dictance(triangle.vertex2, origin) < Dictance(closerVertex, origin))
                {
                    closerVertex = triangle.vertex2;
                    closerTriangle = triangle;
                }
                if (Dictance(triangle.vertex3, origin) < Dictance(closerVertex, origin))
                {
                    closerVertex = triangle.vertex2;
                    closerTriangle = triangle;
                }
            }
            Console.WriteLine("Closer triangle to origin:");
            closerTriangle.Print(closerTriangle);
        
        }

        public void Print(Triangle triangle)
        {
            Console.WriteLine("Triangle: ");
            Console.WriteLine($"Point A: X = {triangle.vertex1.X}  Y = {triangle.vertex1.Y}");
            Console.WriteLine($"Point B: X = {triangle.vertex2.X}  Y = {triangle.vertex2.Y}");
            Console.WriteLine($"Point C: X = {triangle.vertex3.X}  Y = {triangle.vertex3.Y}");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(new Point(1, 1), new Point(2,2), new Point(0,1));
            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(new Point(1, 1), new Point(3, 5), new Point(6, 7)));
            triangles.Add(new Triangle(new Point(2, 2), new Point(3, 2), new Point(1, 4)));
            triangles.Add(new Triangle(new Point(0, 5), new Point(2, 7), new Point(6, 3)));
            triangles.Add(triangle);

            triangle.FindCloseToOrigin(triangles);

            
            

        }
    }
}

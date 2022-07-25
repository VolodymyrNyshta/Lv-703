using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public struct Point
    {
        public double X, Y;
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
    public class Triangle
    {
        private Point vertex1, vertex2, vertex3;
        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }
        public double Distance(Point a, Point b)
        {
            return Math.Round(Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2)),2);
        }
        public double Perimeter()
        {
            return Distance(vertex1, vertex2) 
                + Distance(vertex2, vertex3) 
                + Distance(vertex3, vertex1);
        }
        public double Square()
        {
            double p = Perimeter() / 2;
            return Math.Round(Math.Sqrt(p * (p - Distance(vertex1, vertex2)) * (p - Distance(vertex2, vertex3)) * (p - Distance(vertex3, vertex1))), 2);
        }
        public void Print()
        {
            Console.WriteLine("Triangle - vertex1{0}, vertex2{1}, vertex3{2}", vertex1.ToString(), vertex2.ToString(), vertex3.ToString());
            Console.WriteLine("have perimeter: {0}, square: {1}", Perimeter(), Square());
        }
        public double MinimalDistance()
        {
            double d1 = Distance(new Point(0, 0), vertex1);
            double d2 = Distance(new Point(0, 0), vertex2);
            double d3 = Distance(new Point(0, 0), vertex3);
            return d1 < d2 ? (d1 < d3 ? d1 : d3) : (d2 < d3 ? d2 : d3);
        }
     }
}

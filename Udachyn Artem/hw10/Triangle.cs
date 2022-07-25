using System;
using System.Collections.Generic;
using System.Text;

namespace task_hw10
{
    public class Triangle
    {
        Point a;
        Point b;
        Point c;
        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Perimetr()
        {
            return a.Distance(b) + b.Distance(c) + c.Distance(a);
        }
        public double Square()
        {
            return Math.Sqrt((Perimetr() / 2) * ((Perimetr() / 2) - a.Distance(b)) * ((Perimetr() / 2) - b.Distance(c)) * ((Perimetr() / 2) - c.Distance(a)));
        }
        public void Print()
        {
            Console.WriteLine($"AB: {a.Distance(b):F3}, BC: {b.Distance(c):F3}, CA: {c.Distance(a):F3}, Perimetr: {Perimetr():F3}, area: {Square():F3}");
        }
    }
}

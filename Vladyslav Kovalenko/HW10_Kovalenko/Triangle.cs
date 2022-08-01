using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10_Kovalenko
{
    public class Triangle
    {
        private Point _point1;
        private Point _point2;
        private Point _point3;

        public Triangle(Point a, Point b, Point c)
        {
            _point1 = a;
            _point2 = b;
            _point3 = c;
        }

        public Point Votrex1 { get { return _point1; } }
        public Point Vortex2 { get { return _point2; } }
        public Point Vortex3 { get { return _point3; } }

        public double Perimeter()
        {
            return Votrex1.Distance(Vortex2)
                + Vortex2.Distance(Vortex3)
                + Vortex3.Distance(Votrex1);
        }

        public double Square()
        {
            double halfOfPerimeter = Perimeter() / 2;

            return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - Votrex1.Distance(Vortex2))
                * (halfOfPerimeter - Vortex2.Distance(Vortex3))
                * (halfOfPerimeter - Vortex3.Distance(Votrex1)));
        }

        public void Print()
        {
            Console.WriteLine($"Triangle with vertices {_point1} , {_point2} , {_point3} " +
                $"has Square = {this.Square():F2} and Perimeter = {this.Perimeter():F2}");
        }

    }
}

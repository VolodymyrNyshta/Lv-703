using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    class Circle : Shape
    {
        private double radius;
        public double Radius { get { return radius;  } set { radius = value; } }
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Math.Pow(radius, 2);
        }
    }
}

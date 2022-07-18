using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    class Square :Shape
    {
        private double side;
        public double Side { get { return side; } set { side = value; } }
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return Math.Pow(side, 2);
        }
        public override double Perimeter()
        {
            return side * 2;
        }
    }
}

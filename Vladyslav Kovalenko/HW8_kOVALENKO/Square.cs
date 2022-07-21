using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_Kovalenko
{
    internal class Square : Shape
    {
        private double side;
        public double Side { get { return side; } set { side = value; } }
        public Square(string name, double side) : base(name)
        {
            this.Side = side;
        }
        public override double Area()
        {
            return Side * side;
        }
        public override double Primeter()
        {
            return Side *4;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius 
        { 
            get { return radius; }
            set { radius = value; }
        }
        public Circle(string name,double radius) : base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            double area;
            area = Math.PI * Math.Pow(this.radius, 2);
            return area;
        }
        public override double Perimeter()
        {
            double perimeter;
            perimeter = 2 * this.radius * Math.PI;
            return perimeter;
        }
        public override void Print()
        {
            Console.WriteLine($"{this.Name} Radius: {this.Radius,7:F2} Area: {this.Area(),9:F2} Perimeter: {this.Perimeter(),9:F2}");
        }
    }
}

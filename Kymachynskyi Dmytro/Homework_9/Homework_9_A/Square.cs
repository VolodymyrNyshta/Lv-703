﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_A
{
    public class Square : Shape
    {
        private double side;
        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            double area = this.side * this.side;
            return area;
        }
        public override double Perimeter()
        {
            double perimeter = this.side * 4;
            return perimeter;
        }
        public override void Print()
        {
            Console.WriteLine($"{this.Name} | Side: {this.Side,9:F2} | Area: {this.Area(),9:F2} | Perimeter: {this.Perimeter(),9:F2}");
        }
        public override string OutputToString()
        {
            return $"{this.Name} | Side: {this.Side,9:F2} | Area: {this.Area(),9:F2} | Perimeter: {this.Perimeter(),9:F2}";
        }
    }
}

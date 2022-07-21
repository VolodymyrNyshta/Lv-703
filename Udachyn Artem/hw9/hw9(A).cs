using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace HW9
{
    abstract class Shape : IComparable
    {
        private string name;
        public string Name { get { return name; } }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimetr();

        public int CompareTo(object obj)
        {
            Shape p1 = obj as Circle;
            Shape p2 = obj as Square;
            if (p1 != null)
            {
                return Area().CompareTo(p1.Area());
            }
            else if (p2 != null)
            {
                return Area().CompareTo(p2.Area());
            }
            else
                throw new ArgumentException("Object != Staff");
        }


    }
    class Circle : Shape
    {
        private double radius;
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override double Perimetr()
        {
            return 2 * Math.PI * radius;
        }
    }
    class Square : Shape
    {
        private double side;
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return Math.Pow(side, 2);
        }
        public override double Perimetr()
        {
            return 4 * side;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Square("Square1",4.2),
                new Square("Square2",0.5),
                new Circle("Circl2",0.1),
                new Circle("CirclC3",0.78),
                new Square("Squar5",2.8),
                new Circle("CirclN5",6.2)
            };
            foreach (var item in shapes)
            {
                Console.WriteLine(item.Perimetr());

            }
            foreach (var item in shapes)
            {
                string str = Convert.ToString((int)item.Area());
                Regex regex = new Regex("^[1-9][0-9]$|^100$");
                using StreamWriter writer = new StreamWriter(@"D:\hw9.txt", true);
                if (regex.IsMatch(str))
                {
                    writer.WriteLine("Area from 10 to 100: name of shape: {0}, area: {1}, perimetr: {2}", item.Name, item.Area(), item.Perimetr());
                }
                if (item.Name.Contains("a"))
                {
                    writer.WriteLine("Name of shape: {0}, name contains a", item.Name);
                }
            }

            var task = shapes.Where(x => x.Perimetr() > 5);
            Console.WriteLine();
            foreach (var item in task)
            {
                Console.WriteLine(item.Perimetr());
            }
        }
    }
}

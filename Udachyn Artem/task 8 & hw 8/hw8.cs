using System;
using System.Collections.Generic;

namespace HW8
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
                new Circle("Circle1",2.5),
                new Square("Square1",4.2),
                new Square("Square2",2),
                new Square("Squara3",17),
                new Square("SquarO4",8.71),
                new Circle("Circl2",1),
                new Circle("CirclC3",23),
                new Circle("Circle4",4.3),
                new Square("Squar5",2.8),
                new Circle("CirclN5",6.2)

            };
            foreach (var item in shapes)
            {
                if (item.GetType() == typeof(Circle))
                {
                    Console.WriteLine("Area of circle: {0:F2}", item.Area());
                    Console.WriteLine("Perimetr of circle: {0:F2}", item.Perimetr());
                }
                if (item.GetType() == typeof(Square))
                {
                    Console.WriteLine("Area of square: {0:F2}", item.Area());
                    Console.WriteLine("Perimetr of square: {0:F2}", item.Perimetr());

                }
            }
            Console.WriteLine("Max perimetr");
            double temp = shapes[1].Perimetr();
            string name = "";
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Perimetr() > temp)
                {
                    temp = shapes[i].Perimetr();
                    name = shapes[i].Name;
                }
            }
            Console.WriteLine("Name of shape: {0}, largest perimetr: {1:F2}", name, temp);

            shapes.Sort();
            Console.WriteLine();
            foreach (var item in shapes)
            {
                Console.WriteLine("Name of shape: {0}, area: {1}", item.Name, item.Area());
            }
        }
    }
}
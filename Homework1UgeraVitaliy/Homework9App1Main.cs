using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Homework9App1
{
    internal class Program
    {
        public static readonly string path = @"G:\repository\VS2022\Homework9\Homework9\NewFile.txt";
        static void Main(string[] args)
        {
            //Homework9App1Part1
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle("Circle1"));
            shapes.Add(new Circle("Circle2"));
            shapes.Add(new Circle("Circle3"));
            shapes.Add(new Square("Square1"));
            shapes.Add(new Square("Square2"));
            shapes.Add(new Square("Square3"));

            //Homework9App1Part2
            using (StreamWriter streamWriter = new StreamWriter(File.Create(path)))
            {
                var nameInCertainFormat = from shape in shapes where shape.Area() > 10 && shape.Area() < 100 select new { shape.Name };
                foreach (var name in nameInCertainFormat)
                {
                    streamWriter.WriteLine("Name: {0}", name.Name);
                }
            }

            //Homework9App1Part3
            using (StreamWriter streamWriter = new StreamWriter(File.Create(path)))
            {
                foreach (Shape shape in shapes)
                {
                    if (Regex.IsMatch(shape.Name, "a"))
                    {
                        streamWriter.WriteLine("Name: " + shape.Name + ",Area: " + shape.Area());
                    }
                }
            }

            //Homework9App1Part4
            Console.WriteLine("All shapes:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Name: " + shape.Name + ", Perimeter: " + shape.Perimeter());
            }
            shapes.RemoveAll(item => item.Perimeter() < 5);
            Console.WriteLine("All shapes with perimeter less than 5 :");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Name: " + shape.Name);
            }

        }
    }
}

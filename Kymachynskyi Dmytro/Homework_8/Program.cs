using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            do
            {
                string shapeType;
                Console.WriteLine($"Enter shape № {shapes.Count + 1} type (s for square / c for circle:)");
                shapeType = Console.ReadLine();
                switch (shapeType.ToLower())
                {
                    case "s":
                    squareStart:
                        try
                        {
                            string squareName = "Square_" + (shapes.Count(s => s.Name.Contains("Square")) + 1);
                            Console.WriteLine($"Name of new square shape is: {squareName}");
                            Console.WriteLine("Enter the length of the side:");
                            double squareSide = Convert.ToDouble(Console.ReadLine());
                            Square square = new Square(squareName, squareSide);
                            shapes.Add(square);
                        }
                        catch (FormatException exc)
                        {
                            Console.WriteLine(exc.Message);
                            goto squareStart;
                        }
                        break;
                    case "c":
                    circleStart:
                        try
                        {
                            string circleName = "Circle_" + (shapes.Count(s => s.Name.Contains("Circle")) + 1);
                            Console.WriteLine($"Name of new square shape is: {circleName}");
                            Console.WriteLine("Enter the radius:");
                            double circleRadius = Convert.ToDouble(Console.ReadLine());
                            Circle circle = new Circle(circleName, circleRadius);
                            shapes.Add(circle);
                        }
                        catch (FormatException exc)
                        {
                            Console.WriteLine(exc.Message);
                            goto circleStart;
                        }
                        break;
                    default: 
                        Console.WriteLine("Unknown shape type");
                        break;
                }

            }
            while (shapes.Count < 10);
            foreach (Shape shape in shapes)
            {
                shape.Print();
            }
            var result = shapes.FirstOrDefault(s => s.Perimeter() == shapes.Max(s1 => s1.Perimeter()));
            Console.WriteLine("\nShape {0} have max perimeter: {1:F2}",result.Name, result.Perimeter());
            Console.WriteLine("\nSorting list by area:");
            shapes.Sort();
            foreach (Shape shape in shapes)
            {
                shape.Print();
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NUMBEROFSHAPES = 10;
            List<Shape> shapes = new List<Shape>();
            shapes.Capacity = NUMBEROFSHAPES;
            //Homework8Part1
            for (int i = 0; i < shapes.Capacity;)
            {
                Console.WriteLine("What do you want to create next?");
                string inputedValue = Console.ReadLine();
                if (inputedValue == "Circle")
                {
                    Console.Write("Input the name of the circle : ");
                    string circleName = Console.ReadLine();
                    shapes.Add(new Circle(circleName));
                    i++;
                }
                else if (inputedValue == "Square")
                {
                    Console.Write("Input the name of the square : ");
                    string squareName = Console.ReadLine();
                    shapes.Add(new Square(squareName));
                    i++;
                }
                else
                {
                    Console.WriteLine("Wrong choise, there is only : \"Circle\" or \"Square\"");
                }
            }
            Console.WriteLine("");
            foreach (var shape in shapes)
            {
                if (shape.GetType() == typeof(Circle))
                {
                    Console.WriteLine("Circle with name : {0}", shape.Name);
                    Console.WriteLine("Its ares is : {0:F2}, and perimeter : {1:F2}", shape.Area(), shape.Perimeter());
                }
                else if(shape.GetType() == typeof(Square))
                {
                    Console.WriteLine("Square with name : {0}", shape.Name);
                    Console.WriteLine("Its ares is : {0:F2}, and perimeter : {1:F2}", shape.Area(), shape.Perimeter());
                }
            }

            //Homework8Part2
            double maxP = 0.0;
            string name = string.Empty;
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Perimeter() > maxP)
                {
                    maxP = shapes[i].Perimeter();
                    name = shapes[i].Name;
                }
            }
            Console.WriteLine("Name of the shape with greatest perimeter is : ", name);

            //HomeworkPart3
            Shape.SortByArea(shapes);

            Console.WriteLine("\nSorted shapes by the Area : ");
            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape name : {0},Area : {1:F2}", shape.Name, shape.Area());
            }
            Console.WriteLine("\nPress any button to continue...\n");
            Console.ReadKey();

        }
    }
}
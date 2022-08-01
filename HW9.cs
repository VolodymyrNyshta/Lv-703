using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Homework9
{
    internal class HW9
    {
        static void Main(string[] args)
        {
            // TASK A

            List<Shape> shapes = new List<Shape>();
            Console.WriteLine("Enter the information about 6 different shapes:");
            const int LENGHT = 6;
            while (shapes.Count < LENGHT)
            {
                try
                {
                    Console.WriteLine("Write the name and side of the Shape[{0}].", shapes.Count + 1);
                    Console.WriteLine("Add to the beginning of name letter 'S' for square or 'C' for circle.");
                    string name = Console.ReadLine();
                    double side = Convert.ToDouble(Console.ReadLine());
                    if (side <= 0)
                        throw new ApplicationException("The lenght of side can't be less than 0");
                    if (name.StartsWith('S'))
                    {
                        Square square = new Square(name, side);
                        shapes.Add(square);
                    }
                    else if (name.StartsWith('C'))
                    {
                        Circle circle = new Circle(name, side);
                        shapes.Add(circle);
                    }
                    else
                        throw new ApplicationException("Enter correct name of the shape!");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }

            }
            Console.WriteLine("\n\nThe list of shapes");
            foreach (Shape shape in shapes)
                shape.Print();

            string path = @"W:\Programing\C#\Homework9\Homework9\TextFile.txt";
            using (StreamWriter sWriter = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                IEnumerable<Shape> res = shapes.Where(i => (i.Area() >= 10 && i.Area() <= 100));
                sWriter.WriteLine("The shapes with area in range of 10 and 100");
                foreach (Shape shape in res)
                {
                    sWriter.WriteLine(shape.Name);
                }
                sWriter.WriteLine("\nThe shapes which name contains letter 'a'");
                var shapesWithA = from shape in shapes
                                  where shape.Name.Contains('a')
                                  select shape;
                foreach (var shape in shapesWithA)
                {
                    sWriter.WriteLine(shape.Name);
                }

            }
            Console.WriteLine("\nThe shapes with perimetr less then 5");
            var smallShapes = from shape in shapes
                              where shape.Perimetr() < 5
                              select shape;
            foreach (var shape in smallShapes)
            {
                Console.WriteLine("{0} with perimetr {1}", shape.Name, shape.Perimetr());
            }
            Console.WriteLine();


            // TASK B

            string pathFile = @"W:\Programing\C#\Homework9\Homework9\ALotOfText.txt";
            string[] file = File.ReadAllLines(pathFile);
            int numOfLine = 1;
            foreach(var s in file)
            {
                Console.WriteLine("The {0} line has {1} symbols", numOfLine, s.Length);
                numOfLine++;
            }
            Console.WriteLine();
            int maxLine = file.Max(p => p.Length);
            Console.WriteLine("The longest line has {0} symbols.", maxLine);
            int minLine = file.Min(p => p.Length);
            Console.WriteLine("The shortest line has {0} symbols.", minLine);
            Console.WriteLine();
            var strings = from s in file
                          where s.Contains("var")
                          select s;
            foreach(var s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}

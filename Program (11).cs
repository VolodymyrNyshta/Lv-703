using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string path = @"C:\Users\V\Desktop\SoftServe\test.txt";
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square("Square_A", 2));
            shapes.Add(new Square("Square_B", 8));
            shapes.Add(new Square("Square_C", 6));
            shapes.Add(new Square("Square_D", 4));
            shapes.Add(new Circle("Circle_A", 9));
            shapes.Add(new Circle("Circle_B", 7));
            shapes.Add(new Circle("Circle_C", 5));
            shapes.Add(new Circle("Circle_D", 3));

            //=========================================
            IEnumerable<Shape> query = shapes.Where(x => x.Area() > 10 && x.Area() < 100);
            try
            {
                using (StreamWriter sr = new StreamWriter(path))
                {
                    foreach (Shape item in query)
                    {
                        item.PrintToFile(sr);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //==========================================
            IEnumerable<Shape> query2 = from s in shapes
                                        where s.Name.ToLower().Contains('a')
                                        select s;
            try
            {
                using (StreamWriter sr = new StreamWriter(path))
                {
                    foreach (Shape item in query2)
                    {
                        item.PrintToFile(sr);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //=========================================================

            IEnumerable<Shape> query3 = from s in shapes
                                        where s.Perimeter() > 5
                                        select s;
            shapes.RemoveAll(x => x.Perimeter() < 5);
            foreach (Shape item in shapes)
            {
                Console.WriteLine(item.Perimeter());
            }

            foreach (Shape item in query3)
            {
                Console.WriteLine(item);
            }

            //=========================================================

            //start:
            //    try
            //    {
            //        for (int i = 0; i < 2; i++)
            //        {

            //            Console.Write("Enter Circle name: ");
            //            string name = Console.ReadLine();
            //            Console.WriteLine("Enter radius: ");
            //            double radius = double.Parse(Console.ReadLine());
            //            shapes.Add(new Circle(name, radius));

            //            Console.Write("Enter Square name: ");
            //            string squareName = Console.ReadLine();
            //            Console.WriteLine("Enter side: ");
            //            double side = double.Parse(Console.ReadLine());
            //            shapes.Add(new Square(squareName, side));
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        goto start; 
            //    }

            //    foreach (var item in shapes)
            //    {
            //        Console.WriteLine($"Figure {item.Name} has perimetr: {item.Perimeter():F2}");
            //        Console.WriteLine($"Figure {item.Name} has area: {item.Area():F2}");
            //    }
            //    double max=shapes[0].Perimeter();
            //    int index = 0;
            //    for (int i = 0; i < shapes.Count; i++)
            //    {
            //        if (shapes[i].Perimeter() > max)
            //        {
            //            max = shapes[i].Perimeter();
            //            index = i;
            //        }
            //    }
            //    Console.WriteLine("=========================================");
            //    Console.WriteLine($"Shape with biggest perimetr is {shapes[index].Name}");
            //    Console.WriteLine("=========================================");


            //    Console.WriteLine("============Sorted by area==================");
            //    shapes.Sort();
            //    foreach (var item in shapes)
            //    {
            //        Console.WriteLine($"Figure {item.Name} has area: {item.Area():F2}");
            //    }

        }
    }
}

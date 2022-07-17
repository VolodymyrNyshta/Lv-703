using System;
using System.Collections.Generic;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();
        //Console.WriteLine("Let's create figures");
        //shapes.Add(new Square("Square_A", 2));
        //shapes.Add(new Square("Square_B", 8));
        //shapes.Add(new Square("Square_C", 6));
        //shapes.Add(new Square("Square_D", 4));
        //shapes.Add(new Circle("Circle_A", 9));
        //shapes.Add(new Circle("Circle_B", 7));
        //shapes.Add(new Circle("Circle_C", 5));
        //shapes.Add(new Circle("Circle_D", 3));
        start:
            try
            {
                for (int i = 0; i < 2; i++)
                {
               
                    Console.Write("Enter Circle name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(name, radius));

                    Console.Write("Enter Square name: ");
                    string squareName = Console.ReadLine();
                    Console.WriteLine("Enter side: ");
                    double side = double.Parse(Console.ReadLine());
                    shapes.Add(new Square(squareName, side));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto start; 
            }

            foreach (var item in shapes)
            {
                Console.WriteLine($"Figure {item.Name} has perimetr: {item.Perimeter():F2}");
                Console.WriteLine($"Figure {item.Name} has area: {item.Area():F2}");
            }
            double max=shapes[0].Perimeter();
            int index = 0;
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Perimeter() > max)
                {
                    max = shapes[i].Perimeter();
                    index = i;
                }
            }
            Console.WriteLine("=========================================");
            Console.WriteLine($"Shape with biggest perimetr is {shapes[index].Name}");
            Console.WriteLine("=========================================");


            Console.WriteLine("============Sorted by area==================");
            shapes.Sort();
            foreach (var item in shapes)
            {
                Console.WriteLine($"Figure {item.Name} has area: {item.Area():F2}");
            }

        }
    }
}

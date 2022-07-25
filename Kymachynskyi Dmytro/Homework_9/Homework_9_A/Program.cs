using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_9_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Shape> shapes = new List<Shape>();
                shapes.Add(new Circle("Circle_1", 0.7));
                shapes.Add(new Circle("Circle2a", 6.3));
                shapes.Add(new Circle("Circle_3", 7.4));
                shapes.Add(new Square("Square_1", 5.0));
                shapes.Add(new Square("Square_2", 11.2));
                shapes.Add(new Square("Square_3", 0.4));
                foreach (Shape shape in shapes)
                    shape.Print();
                IEnumerable<Shape> selectedShapes =
                    from shape in shapes
                    where (shape.Area() >= 10) && (shape.Area() <= 100)
                    select shape;
                Console.WriteLine("\nShapes with area from range [10,100]:");
                string filePath = @"C:\SoftServe\Homework_9\selected_shapes.txt";
                using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
                {
                    foreach (Shape shape in selectedShapes)
                    {
                        shape.Print();
                        sw.WriteLine(shape.OutputToString());
                    }
                }
                Console.WriteLine("\nShapes which name contains 'a':");
                selectedShapes = shapes.Where(a => a.Name.IndexOf('a') != -1);
                using (StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default))
                {
                    foreach (Shape shape in selectedShapes)
                    {
                        shape.Print();
                        sw.WriteLine(shape.OutputToString());
                    }
                }
                Console.WriteLine("\nRemove shapes with perimeter < 5:");
                Console.WriteLine("{0} items removed from the list.\nResulted list:", shapes.RemoveAll(s => s.Perimeter() < 5));
                foreach (Shape shape in shapes)
                    shape.Print();
                Console.ReadKey();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}

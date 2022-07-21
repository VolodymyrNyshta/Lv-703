using HW8_Kovalenko;

namespace HW8_kOVALENKO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle("cr1", 1),
                new Circle("cr2", 5.447),
                new Circle("cr3", 251.421),
                new Circle("cr4", 0.4),
                new Circle("cr5", 12.47),
                new Square("sq6", 45.1),
                new Square("sq7", 47.1),
                new Square("sq8", 151.1),
                new Square("sq9", 5.1),
                new Square("sq10", 35.1)
            };
            foreach (var shape in shapes)
            {
                if (shape.GetType() == typeof(Circle))
                {
                    Console.WriteLine("Area of circle: {0:F2}", shape.Area());
                    Console.WriteLine("Perimeter of circle: {0:F2}", shape.Primeter());
                }
                if (shape.GetType() == typeof(Square))
                {
                    Console.WriteLine("Area of square: {0:F2}", shape.Area());
                    Console.WriteLine("Perimetr of square: {0:F2}", shape.Primeter());
                }
            }
                double maxper = shapes[0].Primeter();
                string name = shapes[0].Name;
                for (int i = 0; i < shapes.Count; i++)
                {
                    if (shapes[i].Primeter() > maxper)
                    {
                        maxper = shapes[i].Primeter();
                        name = shapes[i].Name;
                    }
                }
                Console.WriteLine("\nMax perimetr");
                Console.WriteLine($"{name} is the shape with the largest perimetr {maxper}");

                shapes.Sort();
                Console.WriteLine();
                foreach (var item in shapes)
                {
                    Console.WriteLine($"Shape: {item.Name}, area: {item.Area():F2}");
                }

        }
    }
}


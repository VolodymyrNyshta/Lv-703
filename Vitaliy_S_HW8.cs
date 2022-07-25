namespace Vitaliy_S_HW_8
{
    abstract class Shape : IComparable<Shape>
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        public Shape(string name)
        {
            this.name = name;
        }
        abstract public double Area();
        abstract public double Perimetr();

        public int CompareTo(Shape? other)
        {
            if (this.Area() > other.Area())
            {
                return 1;
            }
            else if (this.Area() < other.Area())
            {
                return -1;
            }
            else
                return 0;
        }
    }
    class Circle : Shape
    {
        private double radius;
        public Circle(string name) : base(name)
        {
        A1:
            try
            {
                Console.WriteLine($"Type radius of the {name}");
                radius = Convert.ToDouble(Console.ReadLine());
                if (radius <= 0) throw new ApplicationException("rudius can't be negative or equal to zero");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
                goto A1;
            }
        }
        public override double Area()
        {
            return Math.PI * (radius * radius);
        }
        public override double Perimetr()
        {
            return 2 * Math.PI * radius;
        }
    }
    class Square : Shape
    {
        private double side;
        public Square(string name) : base(name)
        {
        A2:
            try
            {
                Console.WriteLine($"Type side of the {name}");
                side = Convert.ToDouble(Console.ReadLine());
                if (side <= 0) throw new ApplicationException("side can't be negative or equal to zero");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
                goto A2;
            }
        }
        public override double Area()
        {
            return 2 * side;
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
                new Circle("Circle N_1"),
                new Circle("Circle N_2"),
                new Circle("Circle N_3"),
                new Circle("Circle N_4"),
                new Circle("Circle N_5"),
                new Square("Square N_1"),
                new Square("Square N_2"),
                new Square("Square N_3"),
                new Square("Square N_4"),
                new Square("Square N_5")
            };
            Console.WriteLine();
            foreach (var item in shapes)
            {
                if (item.GetType() == typeof(Circle))
                {
                    Console.WriteLine($"    Area of {item.Name} = {item.Area():F2}");
                    Console.WriteLine($"Perimetr of {item.Name} = {item.Perimetr():F2}\n");
                }
                if (item.GetType() == typeof(Square))
                {
                    Console.WriteLine($"    Area of {item.Name} = {item.Area():F2}");
                    Console.WriteLine($"Perimetr of {item.Name} = {item.Perimetr():F2}\n");

                }
            }
            double maxper = shapes[0].Perimetr();
            string name = shapes[0].Name;
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Perimetr() > maxper)
                {
                    maxper = shapes[i].Perimetr();
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
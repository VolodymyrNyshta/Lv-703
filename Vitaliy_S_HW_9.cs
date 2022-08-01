namespace Vitaliy_S_HW_9
{
    internal class Program
    {
        static void Main(string[] args)
        //TASK A
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle("Circle N_1", 0.5),
                new Circle("Circle N_2", 3.2),
                new Circle("Circle N_3", 100.2),
                new Square("Square N_1", 19.5),
                new Square("Square N_2", 9.2),
                new Square("Square N_3", 13.2)
            };
            string path = @"C:\Users\smukv\Documents\SoftServe\ShapesInRange.txt";
            string path_a = @"C:\Users\smukv\Documents\SoftServe\ShapesWitha.txt";
            using StreamWriter sw_range = new StreamWriter(path);

            IEnumerable<Shape> range = shapes.Where(Shape => (Shape.Area() > 10 && Shape.Area() < 100));
            foreach (var item in range)
            {
                sw_range.WriteLine($"{item.Name} with area of {item.Area()}");
            }
            using StreamWriter sw_a = new StreamWriter(path_a);
            {
                foreach (var item in shapes)
                {
                    if (item.Name.Contains('a'))
                    {
                        sw_a.WriteLine($"shape with name {item.Name} contains letter 'a'");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Shapes with Perimetr less than 5 were removed. Remaining list find bellow:");
            foreach (var item in shapes)
            {
                if (item.Perimetr() > 5)
                {
                    Console.WriteLine($"Shape name: {item.Name} Perimetr: {item.Perimetr():F2}");
                }
            }
            Console.WriteLine();
            //TASK B
            string path_text = @"C:\Users\smukv\Documents\SoftServe\A_lot_of_text.txt";
            string[] stringArray = File.ReadAllLines(path_text);
            int line = 1;
            foreach (var item in stringArray)
            {
                Console.WriteLine($"The {line} line has {item.Length} symbols\n");
                line++;
            }
            int longestLine = stringArray.Max(stringArray => stringArray.Length);
            int shortestLine = stringArray.Min(stringArray => stringArray.Length);
            int line_L = 1;
            int line_S = 1;
            foreach (var item in stringArray)
            {
                if (item.Length == longestLine)
                {
                    Console.WriteLine($"Line {line_L} is the longest line with {longestLine} symbols");
                }
                else line_L++;
                if (item.Length == shortestLine)
                {
                    Console.WriteLine($"Line {line_S} is the shortest line with {shortestLine} symbols");
                }
                else line_S++;
            }
            Console.WriteLine("\n Bellow you will find lines, which consist of word 'Offer'\n");
            foreach (var item in stringArray)
            {
                if (item.Contains("Offer"))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
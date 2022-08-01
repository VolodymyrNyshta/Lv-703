namespace HW10_Kovalenko
{
    public struct Point
    {
        public int X, Y;
        public Point(int x, int y)
        {
           this.X = x;
           this.Y = y;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public double Distance(Point p2)
        {
            return Math.Sqrt((this.X - p2.X) * (this.X - p2.X) + (this.Y - p2.Y) * (this.Y - p2.Y));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(new Point(0, 0), new Point(0, 4), new Point(3, 0)));
            triangles.Add(new Triangle(new Point(0, 0), new Point(0, 2), new Point(2, 2)));
            triangles.Add(new Triangle(new Point(4, 9), new Point(13, 9), new Point(14, 9)));
            foreach (Triangle triangle in triangles)
            {
                triangle.Print();
            }
            Console.ReadKey();
        }
        
    }
}
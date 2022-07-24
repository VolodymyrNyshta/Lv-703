using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW10
{
    public class Triangle
    {
        Point vertex1, vertex2, vertex3;
        public Point Vertex1 { get { return vertex1; } set { vertex1 = value; } }
        public Point Vertex2 { get { return vertex2; } set { vertex2 = value; } }
        public Point Vertex3 { get { return vertex3; } set { vertex3 = value; } }
        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            double side_1 = Distance(vertex1, vertex2);
            double side_2 = Distance(vertex1, vertex3);
            double side_3 = Distance(vertex2, vertex3);
            try
            {
                if(!(side_1 + side_2 > side_3 && side_1 + side_3 > side_2 && side_3 + side_2 > side_1))
                {
                    throw new ApplicationException("Triangle with that points doesn't exist");
                }
                this.vertex1 = vertex1;
                this.vertex2 = vertex2;
                this.vertex3 = vertex3;
            }
            catch(ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public double Distance(Point a, Point b)
        {
            return Math.Round(Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2)), 2);
        }
        public double Perimeter()
        {
            return Math.Round(Distance(this.Vertex1, this.Vertex2) + Distance(this.Vertex2, this.Vertex3) + Distance(this.Vertex1, this.Vertex3), 2);
        }
        public double Square()
        {

            double halfPerimeter = this.Perimeter() / 2;
            return Math.Round(Math.Sqrt(halfPerimeter * (halfPerimeter - Distance(this.Vertex1, this.Vertex2)) * (halfPerimeter - Distance(this.Vertex2, this.Vertex3)) * (halfPerimeter - Distance(this.Vertex1, this.Vertex3))), 2);
        }
        public void Print()
        {
            Console.WriteLine($"The first vertex: {vertex1}. The second vertex: {vertex2}. The third vertex: {vertex3}.\nPerimeter equals to {this.Perimeter()} and Square equals to {this.Square()}.");
        }
        public List<double> DistancesToOrigin()
        {
            List<double> result = new List<double>();
            result.Add(this.Distance(this.Vertex1, new Point(0, 0)));
            result.Add(this.Distance(this.Vertex2, new Point(0, 0)));
            result.Add(this.Distance(this.Vertex3, new Point(0, 0)));
            return result;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Triangle> triangleList = new List<Triangle>();
            triangleList.Add(new Triangle(new Point(4, 8), new Point(10, 11), new Point(3, 7)));
            triangleList.Add(new Triangle(new Point(1, 2), new Point(4, 5), new Point(6, 1)));
            triangleList.Add(new Triangle(new Point(10, 5), new Point(19, 30), new Point(17, 13)));
            foreach (Triangle triangle in triangleList)
            {
                triangle.Print();
                Console.WriteLine();
            }
            Console.WriteLine("Triangle with the vertex closest to (0,0):"); 
            triangleList.OrderBy(t => t.MinimalDistance()).First().Print();
        }
    }
}

using System;
using System.Collections.Generic;

namespace task_hw10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>()
            {
                new Triangle(new Point(0,1), new Point(1,-1), new Point(-1,0)),
                new Triangle(new Point(20,11), new Point(11,45), new Point(45,20)),
                new Triangle(new Point(7,16), new Point(16,-10), new Point(-10,7))
            };
            foreach (var item in triangles)
            {
                item.Print();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace task_hw10
{
    public class Point
    {
        private int x;
        private int y;
        public int Y { get; set; }
        public int X { get; set; }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(Point p2)
        {
            return Math.Sqrt(Math.Pow((p2.x - this.x), 2) + Math.Pow((p2.y - this.y), 2));
        }
        public override string ToString()
        {
            return $"x: {x}, y: {y}";
        }
    }
}

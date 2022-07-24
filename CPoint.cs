using System;
using System.Collections.Generic;
using System.Text;

namespace HW10
{
     public struct Point
    {
        public int x;
        public int y;
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public override string ToString()
        {
            return String.Format($"({x}, {y})");
        }
    }
}

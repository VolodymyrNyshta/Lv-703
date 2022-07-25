using System;
namespace Homework10
{
    public class Point
    {
        private int x;
        private int y;
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void PointOutput()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}", X, Y);
        }
    }
}

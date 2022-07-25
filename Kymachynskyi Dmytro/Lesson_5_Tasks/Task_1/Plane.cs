using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Plane : IFlyable
    {
        public string mark;
        public int highFly;
        public Plane(string mark, int highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }

        public void Fly()
        {
            Console.WriteLine($"{mark} plane can fly at {highFly}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Plane : IFlyable
    {
        string mark;
        int highFly;
        public Plane(string mark, int highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }
        public void Fly()
        {
            Console.WriteLine($"Plane {mark} can fly with latitude {highFly} m");
        }
    }
}

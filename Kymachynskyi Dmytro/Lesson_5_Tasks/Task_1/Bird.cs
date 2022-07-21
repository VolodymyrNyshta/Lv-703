using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Bird : IFlyable
    {
        public string name;
        public bool canFly;
        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }
        public void Fly()
        {
            Console.WriteLine(canFly ? "Bird {0} can fly" : "Bird {0} can't fly", name);
        }
    }
}

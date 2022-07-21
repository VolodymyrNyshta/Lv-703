using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> flyObjects = new List<IFlyable>();
            flyObjects.Add(new Plane("Boeing", 10000));
            flyObjects.Add(new Plane("Airbus", 12000));
            flyObjects.Add(new Bird("owl", true));
            flyObjects.Add(new Bird("penguin", false));
            Console.WriteLine("Method 1 (for):");
            for (int i = 0; i < flyObjects.Count; i++) flyObjects[i].Fly();
            Console.WriteLine("\nMethod 2 (foreach):");
            foreach (IFlyable flyobject in flyObjects) flyobject.Fly();
            Console.WriteLine("\nMethod 3 (ForEach delegate):");
            flyObjects.ForEach(delegate (IFlyable flyObject) { flyObject.Fly(); });
            Console.WriteLine("\nMethod 4 (ForEach delegate):");
            flyObjects.ForEach(flyobject => flyobject.Fly());
        }
    }
}

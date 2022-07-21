using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> myList = new List<IFlyable>();
            myList.Add(new Bird("Eagle", true));
            myList.Add(new Plane("Antonow", 10000));
            foreach (var el in myList)
            {
                el.Fly();
            }

            List<int> myColl = new List<int>();
            
            Console.WriteLine("Enter your numbers: ");
            for (int i = 1; i <= 10; i++)
            {
                myColl.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("======== Find -10 position =============");
            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    Console.WriteLine($"Position -10 = {i+1}");
                }
            }
            Console.WriteLine("========= Remove numbers > 20 ============");
            myColl.RemoveAll(digit => digit > 20);
            foreach (var item in myColl)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========== Insert in position and sort ===========");
            myColl.Insert(1, 1);
            myColl.Insert(4, -4);
            myColl.Insert(7, -3);
            myColl.Sort();
            foreach (var item in myColl)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(-1);
            list.Add(5);
            list.Add(-7);
            list.Add(-2);
            list.Add(8);
            list.Add(3);

            IEnumerable<int> negative = from d in list
                                     where d < 0   
                                     select d;
            foreach (int item in negative)
            {
                Console.WriteLine(item);
            }

            var positive = list.Where(x => x > 0);
            
            foreach (int item in positive)
            {
                Console.WriteLine(item);
            }

            int max = list.Max();
            int min = list.Min();
            int sum = list.Sum();
            Console.WriteLine($"min={min}\nmax={max}\nsum={sum}");
            Console.WriteLine($"Average = {list.Average():F2}");
            int el = list.Where(x => x < list.Average()).Max();
            Console.WriteLine(el);
            Console.WriteLine("==========Sorted==========");
            foreach (int item in list.OrderBy(x => x).ToList())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();




        }
    }
}

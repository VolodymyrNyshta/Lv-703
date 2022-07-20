using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, -5, 6, 10, -8, 9, -4, 11 };
            Console.WriteLine("Array:");
            foreach (int i in ints)
                Console.Write($" {i}");
            Console.WriteLine();
            Console.WriteLine("Negative elements:");
            var negativeItems = from i in ints
                        where i < 0
                        select i;
            foreach (var item in negativeItems) Console.WriteLine(item);
            Console.WriteLine("Positive elements:");
            IEnumerable<int> positiveItems = ints.Where(i => i > 0);
            foreach (var item in positiveItems) Console.WriteLine(item);
            Console.WriteLine("Largest item: {0}", ints.Max(i => i));
            Console.WriteLine("Smallest item: {0}", ints.Min(i => i));
            Console.WriteLine("Sum of all elements: {0}", ints.Sum(i => i));
            Console.WriteLine("Average of all elements: {0}", ints.Average());
            Console.WriteLine("Largest item that is smaller than the Average: {0}", ints.Where(i => i < ints.Average()).Max());
            Console.WriteLine("Sorted array:");
            var sorting = ints.OrderBy(i => i);
            foreach (int item in sorting) Console.Write($" {item}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

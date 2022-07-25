using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace HW9_B_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> str = new List<string>();
            using (StreamReader reader = new StreamReader(@"D:\hw9b.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    str.Add(line);
                }
            };
            foreach (var item in str)
            {
                Console.WriteLine("Length: " + item.Length);

            }
            var task2 = from x in str
                        orderby x.Length
                        select x;

            Console.WriteLine("Min: " + task2.First().Length);
            Console.WriteLine("Max: " + task2.Last().Length);

            var task3 = from x in str
                        where x.Contains("var")
                        select x;
            foreach (var item in task3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
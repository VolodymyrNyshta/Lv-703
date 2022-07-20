using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace HW9_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\V\Desktop\SoftServe\Homeworks\Homework5\Homework5\Program.cs";
            List<string> strList = new List<string>();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                while ( sr.ReadLine() != null)
                {
                    strList.Add(sr.ReadLine());
                }
            }
            IEnumerable<string> sortedList = from s in strList
                                         orderby s.Length
                                         select s;
            int i = 1;
            foreach (string item in sortedList)
            {
                Console.WriteLine($"Numbers char in {i} line is {item.Length}");
                i++;
            }
            IEnumerable<int> countSorted = from s in sortedList
                                           let c = s.Count()
                                           select c;

            int max = countSorted.LastOrDefault();
            int min = countSorted.FirstOrDefault();

            Console.WriteLine($"Longest line has {max} sumbols");
            Console.WriteLine(sortedList.LastOrDefault().Trim());
            Console.WriteLine($"Shortest line has {min} sumbols");
            Console.WriteLine(sortedList.FirstOrDefault().Trim());
            Console.WriteLine("Rows with \"Add\"");
            foreach (string item in strList)
            {
                if (item.Contains("Add"))
                    Console.WriteLine(item.Trim());
            }
        }
    }
}

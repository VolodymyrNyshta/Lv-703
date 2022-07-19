using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
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

            string strmax = null;
            string strmin = null;
            int min = strList[1].Trim().Length;
            int max = strList[1].Trim().Length;

            for (int i = 0; i < strList.Count; i++)
            {
                    Console.WriteLine($"Row contain: {strList[i].Trim().Length} sumbols");
                    if (strList[i].Trim().Length > max)
                    {
                        strmax = strList[i].Trim();
                        max = strList[i].Trim().Length;
                    }
                    if (strList[i].Trim().Length < min)
                    {
                        strmin = strList[i].Trim();
                        min = strList[i].Trim().Length;
                    }
                
            }
            Console.WriteLine($"Longest line has {max} sumbols");
            Console.WriteLine(strmax);
            Console.WriteLine($"Shortest line has {min} sumbols");
            Console.WriteLine(strmin);
            Console.WriteLine("Rows with \"Add\"");
            foreach (string item in strList)
            {
                if(item.Contains("Add"))
                    Console.WriteLine(item.Trim());
            }


        }
    }
}

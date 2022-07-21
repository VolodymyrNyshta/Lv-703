using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Homework_9_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = @"C:\SoftServe\Homework_9\Program.cs";
                string[] file = File.ReadAllLines(filePath);
                foreach (string line in file)
                    Console.WriteLine("Symbols {1} in {0}", line, line.Count());
                Console.WriteLine("\nLongest line length: {0}", file.Max(line => line.Length));
                Console.WriteLine(file.OrderByDescending(line => line.Length).First());
                Console.WriteLine("\nShortest line length: {0}", file.Min(line => line.Length));
                Console.WriteLine(file.OrderBy(line => line.Length).First());
                Console.WriteLine("\nLines that contain word \"var\":");
                IEnumerable<string> selectedLines = file.Where(line => Regex.IsMatch(line, @"[\s\/]var[\s]"));
                foreach (string line in selectedLines)
                    Console.WriteLine(line);
                Console.ReadKey();
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}

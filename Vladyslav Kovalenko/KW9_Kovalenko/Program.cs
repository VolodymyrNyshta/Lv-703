using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace KW9_Kovalenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create list of Shape

            List<Shape> shapes = new List<Shape>() 
            {
                new Circle("circle1", 1.56),
                new Square("square1", 3.7),
                new Circle("crircle2", 19.56),
                new Square("square2", 78.1),
                new Circle("crircle3", 1.36),
                new Square("square3", 0.04)
            };

            //Find and write into the file shapes with area from range [10,100]

            List<Shape> shapesWithAreaInRange = new List<Shape>();
            foreach (Shape shape in shapes)
            {
                double result = shape.Area();

                if (result > 10 & result < 100)
                {
                    shapesWithAreaInRange.Add(shape);

                }
            }
            string readPath = @"C:\hw9\shapes_with_area_in_range.txt";
            foreach (Shape shapeWithArea in shapesWithAreaInRange)
            {
                using (StreamWriter sw = new StreamWriter(readPath , true))
                {
                    sw.WriteLine(shapeWithArea.Name + "=" + shapeWithArea.Primeter());
                }
            }
            //Find and write into the file shapes which name contains letter 'a'

            Regex regex = new Regex(@"a");
            string writePath2 = @"C:\hw9\shapes_with_a_in_name.txt";
            foreach (Shape shape in shapes)
            {
                if (regex.IsMatch(shape.Name))
                {
                    using(StreamWriter sw = new StreamWriter(writePath2, true))
                    {
                        sw.WriteLine(shape.Name);
                    }
                }
            }
            //Find and remove from the list all shapes with perimeter less then 5.
            //Write resulted list into Console 

            foreach (Shape shape in shapes.ToList())
            {
                double result = shape.Primeter();
                if (result < 5)
                {
                    shapes.Remove(shape);
                }
            }
            foreach(var item in shapes.ToList())
            {
                Console.WriteLine(item.Name);
            }
            //task b

            List<string> linesOfFile = new List<string>();

            FillListWithData(linesOfFile);
            CalculateAndPrintCharsInEachLine(linesOfFile);
            FindAndPrintLongestAndShortestLinesOfList(linesOfFile);
            List<string> specialLines = FindLinesWithSpecificWord(linesOfFile, "var");
            specialLines.ForEach(line => Console.WriteLine(line));
        }
        
        private static List<string> FindLinesWithSpecificWord(List<string> linesOfFile, string specificWord)
        {
          return  linesOfFile.Where(line => line.Contains(specificWord)).ToList();
        }

        private static void FindAndPrintLongestAndShortestLinesOfList(List<string> linesOfFile)
        {
            string longestLine = FindLongestLine(linesOfFile);
            Console.WriteLine("The longest line is:");
            Console.WriteLine(longestLine);
            string shortestLine = FindShortestLine(linesOfFile);
            Console.WriteLine("The shortest line is:");
            Console.WriteLine(shortestLine);
        }

        private static string FindLongestLine(List<string> linesOfFile)
        {
            return linesOfFile.OrderBy(line => {return line.Count(); }).FirstOrDefault();
        }

        private static string FindShortestLine(List<string> linesOfFile)
        {
            return linesOfFile.OrderBy(line => { return line.Count(); }).LastOrDefault();
        }

        private static void CalculateAndPrintCharsInEachLine(List<string> linesOfFile)
        {
            linesOfFile.ForEach(line => Console.WriteLine(line.Count()));
        }

        private static void FillListWithData(List<string> fileLinesCollection)
        {
            string newreadPath = @"C:\hw9\task b\text.txt";
            
            using (StreamReader reader = new StreamReader(newreadPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    fileLinesCollection.Add(line);
                }
            }
        }
    }
   
}


    
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Homework9App2
{
    internal class Program
    {
        public static readonly string path = @"G:\repository\VS2022\Homework9\Homework9\Program.cs";
        static void Main(string[] args)
        {
            int strings = 0;
            using (StreamReader streamReader = new StreamReader(path))
            {
                while (true)
                {
                    if (streamReader.ReadLine() == null)
                    {
                        break;
                    }
                    else
                    {
                        strings++;
                    }
                }
            }
            string[] arrayOfLines = new string[strings];
            using (StreamReader streamReader = new StreamReader(path))
            {
                for (int i = 0; i < arrayOfLines.Length; i++)
                {
                    if (!streamReader.EndOfStream)
                    {
                        arrayOfLines[i] = streamReader.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            //Homework9App2Part1
            List<int> listOfNumbersOfSymbols = new List<int>();
            int newLine = 0;
            Console.WriteLine("All lines in the array:");
            foreach (var item in arrayOfLines)
            {
                listOfNumbersOfSymbols.Add(item.Length);
                if (newLine % 10 == 0 && newLine != 0) Console.WriteLine();
                if (newLine == arrayOfLines.Length - 1)
                {
                    Console.WriteLine(item.Length + ".");
                }
                else
                {
                    Console.Write(item.Length + ", ");
                }
                newLine++;
            }
            Console.WriteLine();

            //Homework9App2Part2
            Console.WriteLine("The shortest line has {0} elements.", listOfNumbersOfSymbols.Min());
            Console.WriteLine("The longest line has {0} elements.", listOfNumbersOfSymbols.Max());


            //Homework9App2Part3V1
            for (int i = 0; i < arrayOfLines.Length; i++)
            {
                if (arrayOfLines[i].Contains("var"))
                {
                    Console.WriteLine("String number {0} consist of word \"var\" : {1}", i + 1, arrayOfLines[i]);
                }
            }
            //Homework9App2Part3V2
            for (int i = 0; i < arrayOfLines.Length; i++)
            {
                Regex word = new Regex(@"var");
                if (word.IsMatch(arrayOfLines[i]))
                {
                    Console.WriteLine("String number {0} consist of word \"var\" : {1}", i + 1, arrayOfLines[i]);
                }
            }

            Console.ReadKey();
        }
    }
}

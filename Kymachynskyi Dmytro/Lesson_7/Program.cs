using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 part 1
            try
            {
                string filePath = @"C:\SoftServe\Tasks\data.txt";
                string resFilePath = @"C:\SoftServe\Tasks\res.txt";
                List<string> transfer = new List<string>();
                PrintBlueMessage("Task 1.1 - StreamReader - StreamWriter\n");
                Console.WriteLine($"File {filePath} contains:\n");
                using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        transfer.Add(line);
                        Console.WriteLine(line);
                    }
                }
                using (StreamWriter sw = new StreamWriter(resFilePath, false, System.Text.Encoding.Default))
                {
                    foreach (string line in transfer)
                    {
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine($"\nFile {resFilePath} contains:\n");
                using (StreamReader sr = new StreamReader(resFilePath, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                // Task 1 part 2
                PrintBlueMessage("\nTask 1.2 - File.ReadAllText - File.WriteAllText\n");
                Console.WriteLine($"File {filePath} contains:\n");
                string readText = File.ReadAllText(filePath, System.Text.Encoding.Default);
                Console.WriteLine(readText);
                readText = readText + "\n----------THE END----------"; 
                File.WriteAllText(resFilePath, readText, System.Text.Encoding.Default);
                Console.WriteLine($"\nFile {resFilePath} contains:\n");
                string readResText = File.ReadAllText(resFilePath, System.Text.Encoding.Default);
                Console.WriteLine(readResText);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            // Task 2
            try
            {
                PrintBlueMessage("\nTask 2 - Info about dirs and files");
                string dirPath = @"C:\Windows\";
                string resFilePath2 = @"C:\SoftServe\Tasks\resTask2.txt";
                var dir = new DirectoryInfo(dirPath);
                if (dir.Exists)
                {
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    using (StreamWriter sw = new StreamWriter(resFilePath2, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine($" Directory of {dirs[0].Parent.FullName}\n");
                        foreach (DirectoryInfo dirInfo in dirs)
                        {
                            sw.WriteLine("{0:dd.MM.yyyy hh:mm}      <DIR>     {1}", dirInfo.CreationTime, dirInfo.Name);
                        }
                    }
                    FileInfo[] files = dir.GetFiles();
                    using (StreamWriter sw = new StreamWriter(resFilePath2, true, System.Text.Encoding.Default))
                    {
                        foreach (FileInfo fileInfo in files)
                        {
                            sw.WriteLine("{2:dd.MM.yyyy hh:mm} {1,12: ### ### ### ##0}   {0}", fileInfo.Name, fileInfo.Length, fileInfo.CreationTime);

                        }

                    }

                }
                Console.WriteLine($"\nFile {resFilePath2} contains:\n");
                using (StreamReader sr = new StreamReader(resFilePath2, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            // Task 3
            try
            {
                PrintBlueMessage("\nTask 3 - Select and print .txt files");
                string dirPath = @"C:\SoftServe\Tasks\task3\";
                var dir = new DirectoryInfo(dirPath);
                FileInfo[] files = dir.GetFiles();
                Console.WriteLine($"\n Directory of {dirPath}\n");
                foreach (FileInfo fileInfo in files)
                    Console.WriteLine("{2:dd.MM.yyyy hh:mm} {1,12: ### ### ### ##0}   {0}", fileInfo.Name, fileInfo.Length, fileInfo.CreationTime);
                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].Extension == ".txt")
                    {
                        Console.WriteLine($"\nFile {files[i].Name} contains:\n");
                        using (StreamReader sr = new StreamReader(files[i].FullName, System.Text.Encoding.Default))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                }
                Console.WriteLine();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void PrintBlueMessage(string messageToPrint)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(messageToPrint);
            Console.ResetColor();
        }
    }
}

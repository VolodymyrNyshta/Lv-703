using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string myDir = @"C:\Users\V\Desktop\SoftServe";
                if (Directory.Exists(myDir))
                {
                    string[] directories = Directory.GetDirectories(myDir);
                    Console.WriteLine("Directories:");
                    foreach (string dir in directories)
                    {
                        Console.WriteLine(dir);
                    }
                    directories = Directory.GetFiles(myDir);
                    Console.WriteLine("Files:");
                    foreach (string file in directories)
                    {
                        if (file.EndsWith(".txt"))
                        {
                            string rf = File.ReadAllText(file);
                            Console.WriteLine(rf);
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}


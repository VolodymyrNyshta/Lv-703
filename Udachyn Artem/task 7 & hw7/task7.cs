using System;
using System.IO;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string read = @"D:\data.txt";
            string write = @"D:\data1.txt";
            try
            {
                //using StreamReader reader = new StreamReader(read);
                //txt = reader.ReadToEnd();

                //using StreamWriter writer = new StreamWriter(write);
                //writer.WriteLine(txt);

                string txt = File.ReadAllText(read);
                File.WriteAllText(write, txt);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }

            string file = @"D:\DirectoryC.txt";
            DirectoryInfo direct = new DirectoryInfo(@"D:\");
            FileInfo[] files = direct.GetFiles();
            DirectoryInfo[] directories = direct.GetDirectories();
            try
            {
                using StreamWriter writes = new StreamWriter(file);
                foreach (var item in files)
                {
                    writes.WriteLine(item.FullName);
                    writes.WriteLine(item.Length);

                }
                foreach (var item in directories)
                {
                    writes.WriteLine(item.Name);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }


            try
            {
                string reads = @"E:\New";
                string text = "";
                DirectoryInfo directs = new DirectoryInfo(reads);
                FileInfo[] data = directs.GetFiles();
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i].Name.Contains(".txt"))
                    {
                        text = File.ReadAllText(data[i].FullName);
                    }
                }
                Console.WriteLine(text);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
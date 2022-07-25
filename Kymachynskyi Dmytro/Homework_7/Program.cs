using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string phonesFilePath = @"C:\SoftServe\Homework_7\phones.txt";
            string onlyPhonesFilePath = @"C:\SoftServe\Homework_7\onlyphones.txt";
            // For Windows OS phones.txt & Phones.txt are equivalent:
            // https://docs.microsoft.com/en-us/windows/wsl/case-sensitivity
            string newFilePath = @"C:\SoftServe\Homework_7\new.txt";
            try
            {
                //Part 1 ----------------
                Console.WriteLine("File phones.txt:\n");
                using (StreamReader sr = new StreamReader(phonesFilePath, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        string[] parts = line.Split(',');
                        phoneBook[parts[0]] = parts[1];
                    }
                }
                using (StreamWriter sw = new StreamWriter(onlyPhonesFilePath, false, System.Text.Encoding.Default))
                {
                    foreach (string name in phoneBook.Keys)
                        sw.WriteLine(phoneBook[name]);
                }
                Console.WriteLine("\nFile onlyphones.txt:\n");
                OutputFileToConsole(onlyPhonesFilePath);
                //Part 2 ----------------
                Console.WriteLine("\nEnter name to search phone number:");
                string nameToSearch = Convert.ToString(Console.ReadLine());
                bool found = false;
                foreach(string name in phoneBook.Keys)
                {
                    if (name.ToLower() == nameToSearch.ToLower())
                    {
                        found = true;
                        Console.WriteLine($"{name} - {phoneBook[name]}");
                    }
                }
                if (!found) Console.WriteLine($"Phone number for {nameToSearch} not found.");
                Console.WriteLine("\nPress any key...");
                Console.ReadKey();
                //Part 3 method 1 (for) ----------------
                var phoneBookCopy = new Dictionary <string, string>(phoneBook); // copy dictionary for method 2
                Console.WriteLine("\nConvert 80xxxxxxxxx to +380xxxxxxxxx - method 1:\n");
                for (int i = 0; i < phoneBook.Count; i++)
                {
                    KeyValuePair<string, string> entry = phoneBook.ElementAt(i);
                    if (entry.Value.IndexOf("80") == 0)
                    {
                        phoneBook[entry.Key] = "+3" + entry.Value;
                    }
                }
                foreach (string key in phoneBook.Keys)
                    Console.WriteLine(key + " --- " + phoneBook[key]);
                //Part 3 method 2 (foreach) ----------------
                Console.WriteLine("\nConvert 80xxxxxxxxx to +380xxxxxxxxx - method 2:\n");
                string[] keys = new string[phoneBookCopy.Count];
                phoneBookCopy.Keys.CopyTo(keys, 0);
                foreach (string key in keys)
                {
                    if (phoneBookCopy[key].IndexOf("80") == 0)
                    {
                        phoneBookCopy[key] = "+3" + phoneBookCopy[key];
                    }
                }
                foreach (string key in phoneBookCopy.Keys)
                    Console.WriteLine(key + " --- " + phoneBookCopy[key]);
                Console.WriteLine("\nWriting results to new.txt:\n");
                using (StreamWriter sw = new StreamWriter(newFilePath, false, System.Text.Encoding.Default))
                {
                    foreach (string key in phoneBook.Keys)
                    {
                        sw.WriteLine(key + "," + phoneBook[key]);
                    }
                }
                OutputFileToConsole(newFilePath);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message);}
            Console.ReadKey();
        }
        static void OutputFileToConsole(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}

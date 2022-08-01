using System;
using System.IO;
using System.Collections.Generic;
namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  From file "phones.txt" read 9 pairs into PhoneBook.
            //  Write only PhoneNumbers into file "Phones.txt".
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            try
            {
                // reading values from file and adding them to the dictionary.
                string pathPhones = @"W:\Programing\C#\Homework7\Homework7\phones.txt";
                string line = String.Empty;
                StreamReader streamReader = new StreamReader(pathPhones, System.Text.Encoding.Default);
               
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] strings = line.Split(' ');
                    phoneBook.Add(strings[0], strings[1]);
                }
                streamReader.Close();
                foreach(var phone in phoneBook)
                {
                    Console.WriteLine(phone.Key + " " + phone.Value);
                }
                // writing phones to the file 
                string path = @"W:\Programing\C#\Homework7\Homework7\SPhones.txt";
                StreamWriter sWriter = new StreamWriter(path, false, System.Text.Encoding.Default);
                foreach (var phone in phoneBook)
                {
                    sWriter.WriteLine(phone.Value);
                }
                sWriter.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Find and print phone number by the given name (name input from console)
            try
            {
                
                Console.WriteLine("Enter the name to search:");
                string name = Console.ReadLine();  
                foreach (var info in phoneBook)
                {
                    if (info.Key.ToLower() == name.ToLower())
                    {
                        Console.WriteLine(info.Value);
                    }
                }

            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Change all phone numbers, which are in format 80######### into new format +380#########.
            // The result write into file "New.txt«
            try
            {
                string path = @"W:\Programing\C#\Homework7\Homework7\New.txt";
                StreamWriter sWriter = new StreamWriter(path, false, System.Text.Encoding.Default);
                foreach (var info in phoneBook)
                {
                    if (info.Value.StartsWith('8'))
                    {
                        sWriter.WriteLine(info.Key + " " + "+3" + info.Value);
                    }
                    else
                        sWriter.WriteLine(info.Key + " " + info.Value);
                }
                sWriter.Close();

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

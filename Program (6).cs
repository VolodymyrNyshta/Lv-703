using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Homework7
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            string path = @"C:\Users\V\Desktop\SoftServe\phonebook.txt";
            string pathWrite = @"C:\Users\V\Desktop\SoftServe\phones.txt";
            string pathWrite2 = @"C:\Users\V\Desktop\SoftServe\New.txt";
            try
            {
                FileInfo f = new FileInfo(pathWrite);
                if (!f.Exists) { f.Create(); }

                using (StreamReader myStreamReader = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string[] myFile = new string[9];
                    string name, number;
                    for (int i = 0; i < 9; i++)
                    {
                        myFile[i] = myStreamReader.ReadLine();
                        number = myFile[i].Substring(0, 11);
                        name = myFile[i].Substring(12);
                        PhoneBook.Add(number, name);
                    }
                }
                using (StreamWriter myStreamWriter = new StreamWriter(pathWrite, true, System.Text.Encoding.Default))
                {
                    foreach (var item in PhoneBook.Keys)
                    {
                        myStreamWriter.WriteLine(pathWrite);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);            
            }

            Console.Write("Enter person name:");
            string personName = Console.ReadLine();
            foreach (var el in PhoneBook)
            {
                if (el.Value.ToLower().Contains(personName.ToLower())) 
                {
                    Console.WriteLine($"Person {personName} has number {el.Key}");
                }
            }
            try
            {
                using (StreamWriter myStreamWriter2 = new StreamWriter(pathWrite2, false, System.Text.Encoding.Default))
                {
                    foreach (var item in PhoneBook.Keys)
                    {
                        if (!item.StartsWith("+3"))
                        {
                            myStreamWriter2.WriteLine("+3" + item);
                        }
                        else
                        {
                            myStreamWriter2.WriteLine(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
                
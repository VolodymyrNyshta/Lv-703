using System;
using System.IO;
using System.Collections.Generic;

namespace HW7_Kovalenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string path = @"C:\hw7\phones.txt";
            foreach (var phoneNameAndNumberPair in System.IO.File.ReadAllLines(path))
            {
                var section = phoneNameAndNumberPair.Split(' ');
                phoneBook.Add(section[0], section[1]);
            }

            using (StreamWriter streamWriter = File.CreateText(@"C:\hw7\onlyPhones.txt"))
            {
                foreach (var phoneNumberAndNamePair in phoneBook)
                {
                    streamWriter.WriteLine(phoneNumberAndNamePair.Key);
                }
            }

            GetSearchedName(phoneBook);
            FormateChange(phoneBook);
        }
        private static void GetSearchedName(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("Lets find person number through name");
            string searchedName;
            Dictionary<string, string> consistantPhoneBookRecords = new Dictionary<string, string>();
            Console.WriteLine("Enter name of person");
            searchedName = Console.ReadLine();

            foreach (var phoneBookRecord in phoneBook)
            {
                if (phoneBookRecord.Value.ToLower() == searchedName.ToLower())
                {
                    consistantPhoneBookRecords.Add(phoneBookRecord.Key, phoneBookRecord.Value);
                }
            }
            
            if(consistantPhoneBookRecords.Count > 0)
            {
                foreach(var phoneBookRecord in consistantPhoneBookRecords)
                {
                    Console.WriteLine($"This person {phoneBookRecord.Value} have number {phoneBookRecord.Key}");
                }
            }
            else
            {
                Console.WriteLine("This name is not on the list");
            }
        }
        private static void FormateChange(Dictionary<string, string> phoneBook)
        {
            string readPath = @"C:\hw7\onlyPhones.txt";
            string writePath = @"C:\hw7\New.txt";

            using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
            {
                sr.ReadToEnd();
            }

            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                foreach (var info in phoneBook)
                {
                    if (info.Key.StartsWith('8'))
                    {
                        sw.WriteLine("+3" + info.Key);
                    }
                    else
                    {
                        sw.WriteLine(info.Key + info.Value);
                    }
                }
            }
        }


    }
}



using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace VS_HW7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string path = @"C:\Users\smukv\Documents\SoftServe\phones.txt";
            string pathWrite2 = @"C:\Users\smukv\Documents\SoftServe\New.txt";
            foreach (var num in System.IO.File.ReadAllLines(path))
            {
                var val = num.Split(':');
                phonebook.Add(val[0], val[1]);
            }
            using (StreamWriter sw = File.CreateText(@"C:\Users\smukv\Documents\SoftServe\tilkiphones.txt"))
            {
                foreach (var item in phonebook) sw.WriteLine(item.Key);
            }
            Console.WriteLine("To find the number, please enter the name of the person");
            string personName = Console.ReadLine();
            foreach (var item in phonebook)
            {
                if (item.Value.ToLower() == personName.ToLower())
                {
                    Console.WriteLine($"{item.Value} number is {item.Key}");
                }
            }
            using (StreamWriter correctNum = new StreamWriter(pathWrite2))
            {
                foreach (var item in phonebook)
                {
                    if (item.Key.StartsWith('8'))
                    {
                        correctNum.WriteLine("+3" + item.Key);
                    }
                    else
                    {
                        correctNum.WriteLine(item.Key);
                    }
                }
            }
        }
    }
}
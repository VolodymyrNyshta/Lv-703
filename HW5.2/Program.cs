using System;
using System.Collections.Generic;

namespace Homework5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> myDictionary = new Dictionary<uint, string>();
            Console.WriteLine("Enter person info");
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("ID: ");
                uint ID = uint.Parse(Console.ReadLine());
                myDictionary.Add(ID, name);
            }
            Console.Write("Enter ID for search:");
            uint myKey = uint.Parse(Console.ReadLine());
            bool isFaund = false;
            foreach (KeyValuePair<uint, string> keyValue in myDictionary)
            {
                if (keyValue.Key == myKey)
                {
                    Console.WriteLine($"ID = {keyValue.Key} - Name is: {keyValue.Value}");
                    isFaund = true;
                }
            }
            if (!isFaund)
            {
                Console.WriteLine("ID not found");
            }     
        }
    }
}

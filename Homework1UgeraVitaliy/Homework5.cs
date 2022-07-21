using System;
using System.Collections.Generic;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Homework5Part1
            List<IDeveloper> listOfTools = new List<IDeveloper>();
            IDeveloper programmer1 = new Programmer("C#");
            IDeveloper programmer2 = new Programmer("Java");
            IDeveloper builder1 = new Builder("Shovel");
            IDeveloper builder2 = new Builder("Axe");
            listOfTools.Add(programmer1);
            listOfTools.Add(programmer2);
            listOfTools.Add(builder1);
            listOfTools.Add(builder2);
            foreach (IDeveloper tool in listOfTools)
            {
                tool.Create();
                tool.Destroy();
            }
            int valueToReturn = 0;
            int outer, inner;
            for (outer = listOfTools.Count - 1; outer >= 0; outer--)
            {
                for (inner = 1; inner <= outer; inner++)
                {
                    valueToReturn = listOfTools[inner].CompareTo(listOfTools[inner - 1]); //value that defines whether current string is greater, lesser or equals to other one
                    if (valueToReturn == -1)//means that current string presedes other one
                    {
                        IDeveloper temp = listOfTools[inner - 1];
                        listOfTools[inner - 1] = listOfTools[inner];
                        listOfTools[inner] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted tools : ");
            foreach (IDeveloper tool in listOfTools)
            {
                Console.WriteLine("   {0}", tool.Tool);
            }
            Console.WriteLine("\nPress any button to continue...\n");
            Console.ReadKey();

            //Homework5Part2
            string ERROR = "ERROR IS HERE!!!";
            const int DICTIONARYCOUNT = 7; //amount of elements to add to the dictionary accordingly to the task conditions
            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            uint ID = 0;
            string Name = string.Empty;
            Console.WriteLine("Write person ID as the first element and then its name : ");
            for (int i = 0; i < DICTIONARYCOUNT; i++)
            {
                Console.WriteLine("   Number {0} :", i + 1);
                Console.Write("\t");
                ID = Convert.ToUInt32(Console.ReadLine());
                Console.Write("\t");
                Name = Console.ReadLine();
                persons.Add(ID, Name);
            }
            Console.Write("Write the ID : ");
            ID = Convert.ToUInt32(Console.ReadLine());
            if (persons.ContainsKey(ID) && persons.TryGetValue(ID, out ERROR))
            {
                Console.Write("Here is the Name : ");
                foreach (KeyValuePair<uint, string> person in persons)
                {
                    if (person.Key == ID)
                    {
                        string neededPersonName = person.Value;
                        Console.WriteLine(neededPersonName);
                    }
                }
            }
            else
            {
                Console.WriteLine("There is no written ID in dictionary!!!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            var persons = new Person[6];
            persons[0] = person;
            for (int i = 1; i < persons.Length; i++) 
                persons[i] = person.Input();
            Console.WriteLine("\nOutputting persons data...");
            for (int i = 0; i < persons.Length; i++) 
                person.Output(persons[i]);
            Console.WriteLine("\nChecking age to rename persons...");
            for (int i = 0; i < persons.Length; i++)
                if (person.Age(persons[i]) < 16) person.ChangeName(persons[i]);
            Console.WriteLine("\nOutputting persons data...");
            for (int i = 0; i < persons.Length; i++) 
                person.Output(persons[i]);
            Console.WriteLine("\nFinding persons with same names...");
            bool foundFlag = false;
            for (var i = 0; i < persons.Length; i++)
            {
                for (int j = i+1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        person.Output(persons[i]);
                        Console.WriteLine("have the same name to:");
                        person.Output(persons[j]);
                        Console.WriteLine();
                        foundFlag = true;
                    }
                }
            }
            if (!foundFlag) Console.WriteLine("\nNot found persons with same names!");
        }
    }

}

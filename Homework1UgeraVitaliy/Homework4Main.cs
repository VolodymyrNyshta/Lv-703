using System;
using System.Collections.Generic;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write each person's data : ");
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            Person person4 = new Person();
            Person person5= new Person();
            Person person6 = new Person();
            List<Person> persons = new List<Person>();
            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);    
            persons.Add(person4);
            persons.Add(person5);
            persons.Add(person6);
            Console.WriteLine("(there have to be six in total)\n");
            foreach (Person person in persons)
            {
                person.Input();
            }
            Console.WriteLine("\nName and age of each Person: ");
            foreach (Person person in persons)
            {
                int personAge = person.Age();
                Console.WriteLine("Name : {0}, Age : {1}", person.PersonName, personAge);
            }
            Console.WriteLine("\nChanging each person's name whose age is less than 16...");
            foreach (Person person in persons)
            {
                person.ChangeName(person);
            }
            Console.WriteLine("\nView after changes : ");
            foreach (Person person in persons)
            {
                person.Output(person);
            }
            Console.WriteLine("");
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = i + 1; j < persons.Count; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"{persons[i].PersonName} under number {i + 1} and {persons[j].PersonName} under number {j + 1} have the same names!!!");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[6];
            persons[0] = new Person();
            persons[1] = new Person("Ben", new DateTime(2003, 10, 10));
            persons[2] = Person.Input();
            persons[3] = Person.Input();
            persons[4] = new Person();
            persons[5] = new Person("Jack", new DateTime(2010, 06, 11));
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Output();
            }
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Name: {persons[i].Name}, Age: {persons[i].Age()}");
            }
            int old = 16;
            Console.WriteLine("Write new name");
            string name = Console.ReadLine();
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].Age() < old)
                {
                    persons[i].ChangeName(name);
                }
            }
            for (int i = 0; i < persons.Length; i++)
            {
                Console.Write("Age: " + persons[i].Age() + " ");
                persons[i].Output();
            }
            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"{i + 1} person equal {j + 1} person");
                    }
                    else
                    {
                        Console.WriteLine("Persons not equal");
                    }
                }

            }
        }
    }
}

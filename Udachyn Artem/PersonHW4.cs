using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
    class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name { get { return name; } }

        public int BirthYear { get { return birthYear.Year; } }

        public Person()
        {
            name = "Artem";
            birthYear = new DateTime(2000, 10, 15);
        }
        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }
        public int Age()
        {
            return DateTime.Now.Year - birthYear.Year;
        }
        public static Person Input()
        {
            Console.WriteLine("Write name");
            string name = Console.ReadLine();
            Console.WriteLine("Write your birth year");
            DateTime birthYear = Convert.ToDateTime(Console.ReadLine());
            Person person = new Person(name, birthYear);
            return person;
        }
        public void ChangeName(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"My name: {name}, I was born in {birthYear.Year}";
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person first, Person second)
        {
            return first.name == second.name;
        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first.name == second.name);
        }
    }
}

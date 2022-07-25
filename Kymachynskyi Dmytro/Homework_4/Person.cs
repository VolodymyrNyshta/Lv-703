using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    public class Person
    {
        private string name;
        private DateTime birthYear;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }
        public Person() { name = "Undefined"; birthYear = Convert.ToDateTime("01.01.1900"); }
        public Person(string name, DateTime birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }
        public int Age(Person person)
        { return DateTime.Now.Year - person.birthYear.Year; }
        public Person Input()
        {
            Person person = new Person();
            Console.Write("Enter name: ");
            person.name = Console.ReadLine();
            Console.Write("Enter birth date: ");
            person.birthYear = Convert.ToDateTime("01.01." + Console.ReadLine());
            return person;
        }
        public void ChangeName(Person person)
        {
            person.name = "Very young";
        }
        public override string ToString()
        {
            return string.Format($"Person name: {name} age: {Age(this)}");
        }
        public void Output(Person person)
        {
            Console.WriteLine(person);
        }
        public static bool operator == (Person first, Person second)
        {
            return first.name == second.name;
        }
        public static bool operator !=(Person first, Person second)
        {
            return first.name != second.name;
        }

    }
}

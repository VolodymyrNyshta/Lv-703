using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_Kovalenko
{
    internal class Person
    {
        private const int V = 16;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int birthYear;
        public int BirthYear
        {
            get { return birthYear; }
            set { }

        }
        public Person()
        {
        }
        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }
        public void Age()
        {
            Console.WriteLine(2022 - birthYear);
           
        }
        public static Person Input(int i)
        {
            Console.WriteLine($"Enter {i+1} person name ");
            var name = Console.ReadLine();
            Console.WriteLine($"Enter {i+1} person birth year");
            var birthYear = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(name, birthYear);
            return person;
        }
        public void Output()
        {
            Console.WriteLine($"Person  {name}  born in  {birthYear}");
        }

        public override string ToString()
        {
            return ($"Person + {name} + born in + {birthYear}");
        }
        public static bool operator ==(Person first, Person second)
        {
            return (first.name == second.name);

        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first == second);
        }
        public void ChangeName()
        {
            if (2022-birthYear < 16) 
            {
                name = "Very young";
            }
        }

    }
}

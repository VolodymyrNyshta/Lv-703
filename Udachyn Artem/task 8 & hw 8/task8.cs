using System;
using System.Collections.Generic;
using System.IO;

namespace task8
{
    class Person : IComparable
    {
        private string name;
        private string surname;
        private DateTime datebirth;
        virtual public string Name { get { return name; } }
        virtual public string Surname { get { return surname; } }
        virtual public DateTime Date { get { return datebirth; } }

        public Person(string name, string surname, DateTime datebirth)
        {
            this.name = name;
            this.surname = surname;
            this.datebirth = datebirth;
        }
        virtual public void Print()
        {
            Console.WriteLine($"Name: {name}, surname: {surname}, date of birth: {datebirth.ToLongDateString()} ");
        }
        public int CompareTo(object obj)
        {
            Person p1 = obj as Person;
            if (p1 == null)
            {
                throw new ArgumentException("Object != Person");
            }
            else
                return Name.ToLower().CompareTo(p1.Name.ToLower());
        }

    }
    class Student : Person
    {
        private string groupName;
        public Student(string name, string surname, DateTime datebirth, string groupName) : base(name, surname, datebirth)
        {
            this.groupName = groupName;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Group name: {groupName}");
        }
    }
    class Staff : Person, IComparable<Staff>
    {
        private int salary;
        public Staff(string name, string surname, DateTime datebirth, int salary) : base(name, surname, datebirth)
        {
            this.salary = salary;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Salary: {salary}");
        }
        public int CompareTo(Staff obj)
        {
            Staff p1 = obj as Developer;
            Staff p2 = obj as Teacher;
            if (p1 != null)
            {
                return salary.CompareTo(p1.salary);
            }
            else if (p2 != null)
            {
                return salary.CompareTo(p2.salary);
            }
            else
                throw new ArgumentException("Object != Staff");
        }
    }
    class Teacher : Staff
    {
        private string subject;
        public Teacher(string name, string surname, DateTime datebirth, int salary, string subject) : base(name, surname, datebirth, salary)
        {
            this.subject = subject;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Subject: {subject}");
        }
    }
    class Developer : Staff
    {
        private string level;
        public Developer(string name, string surname, DateTime datebirth, int salary, string level) : base(name, surname, datebirth, salary)
        {
            this.level = level;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Level: {level}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Student("Robert","Black",new DateTime(2000,12,12),"L-7"),
                new Student("Jack","Rich",new DateTime(1999,10,01),"K-1"),
                new Staff("Nick","Mich",new DateTime(1990,12,10),1000),
                new Staff("Staff2","Staff2",new DateTime(1997,04,20),1300),
                new Teacher("Anna","Mack",new DateTime(1984,07,20), 2000, "English"),
                new Teacher("Max","Gim",new DateTime(1979,05,30), 4500, "Math"),
                new Developer("Name1","SurName1",new DateTime(2002,12,25),900,"Junior"),
                new Developer("Name2","SurName2",new DateTime(2003,11,10),5000,"Senior")
            };
            foreach (var item in people)
            {
                item.Print();
            }
            Console.WriteLine("Write name");
            string name = Console.ReadLine();
            foreach (var item in people)
            {
                if (item.Name == name)
                {
                    item.Print();
                }
            }
            people.Sort();
            using (StreamWriter writer = new StreamWriter(@"D:\d.txt"))
            {
                foreach (var item in people)
                {
                    writer.WriteLine(item.Name);
                }
            }
            List<Staff> Employees = new List<Staff>();
            foreach (var item in people)
            {
                if (item.GetType() == typeof(Developer))
                {
                    Employees.Add((Staff)item);
                }
                if (item.GetType() == typeof(Teacher))
                {
                    Employees.Add((Staff)item);
                }
            }
            foreach (Staff item in Employees)
            {
                item.Print();
            }
            Employees.Sort();
            Console.WriteLine(new string('-', 50));
            foreach (var item in Employees)
            {
                item.Print();
            }

        }
    }
}
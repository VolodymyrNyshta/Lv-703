using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Task
{
    abstract class Person : IComparable
    {
        private string name;
        public string Name { get { return name; } }
        public Person(string name)
        {
            this.name = name;
        }
        public abstract void Print();
        public abstract void PrintToFile(StreamWriter stream);


        public int CompareTo([AllowNull] Object other)
        {
            Person p = other as Person;
            if (p == null) throw new Exception("Object is not Person");
            else
                return this.Name.ToLower().CompareTo(p.Name.ToLower());
        }
    }
    class Staff : Person, IComparable<Staff>
    {
        private int salary;
        public int Salary { get { return salary; } }
        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Salary: {Salary}");
        }
        public override void PrintToFile(StreamWriter stream)
        {
            stream.WriteLine($"Name: {Name} Salary: {Salary}");
        }

        public int CompareTo([AllowNull] Staff other)
        {
            if (this.Salary > other.Salary)
            { return 1; }
            else if (this.Salary < other.Salary)
            { return -1; }
            else
                return 0;

        }
    }
    class Teacher : Staff
    {
        private string subject;
        public Teacher(string name, int salary, string subject) : base(name, salary)
        {
            this.subject = subject;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Salary: {Salary} Subject: {subject}");
        }
        public override void PrintToFile(StreamWriter stream)
        {
            stream.WriteLine($"Name: {Name} Salary: {Salary} Subject: {subject}");
        }
    }

    class Developer : Staff
    {
        private int level;
        public int Level { get { return level; } }
        public Developer(string name, int salary, int level) : base(name, salary)
        {
            this.level = level;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Salary: {Salary} Level: {level}");
        }
        public override void PrintToFile(StreamWriter stream)
        {
            stream.WriteLine($"Name: {Name} Salary: {Salary} Level: {level}");
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<Person> list = new List<Person>();
                list.Add(new Teacher("Alex", 1000, "C#"));
                list.Add(new Developer("Oleh", 2500, 5));
                list.Add(new Staff("Ivan", 500));
                list.Add(new Teacher("Serhij", 1500, "Java"));
                list.Add(new Developer("Petro", 2000, 5));
                list.Add(new Staff("Ivasyk", 700));
                foreach (var item in list)
                {
                    item.Print();
                }
                Console.WriteLine("================================");
                string name = "Alex";
                bool flag = false;
                foreach (var item in list)
                {
                    if (item.Name == name)
                    {
                        item.Print();
                        flag = true;
                    }
                    if (!flag) Console.WriteLine("There are nobody with this name");
                }

                Console.WriteLine("================================");
                string path = @"C:\Users\V\Desktop\SoftServe\test.txt";
                list.Sort();
                foreach (var item in list)
                {
                    item.Print();
                }
                Console.WriteLine("================================");

                try
                {
                    using (StreamWriter sr = new StreamWriter(path))
                    {
                        foreach (var item in list)
                        {
                            item.PrintToFile(sr);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                List<Staff> newList = new List<Staff>();
                foreach (Staff item in list)
                {
                    if (item.GetType() == typeof(Developer) || item.GetType() == typeof(Teacher))
                    {
                        newList.Add(item);
                    }
                }
              
                newList.Sort();

                foreach (var item in newList)
                {
                    item.Print();
                }
            }
        }
    }
}


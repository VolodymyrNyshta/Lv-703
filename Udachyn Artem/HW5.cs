using System;
using System.Collections.Generic;

namespace HW5
{
    interface IDeveloper : IComparable<IDeveloper>
    {
        public string Tool { get; set; }
        void Create();
        void Destroy();
    }
    class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        string language;
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }
        public Programmer(string language)
        {
            this.language = language;
        }
        public void Create()
        {
            Console.WriteLine("Create program on language: {0}", language);
        }
        public void Destroy()
        {
            Console.WriteLine("Destroy program with tool: {0}", Tool);
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return string.Compare(this.Tool, other.Tool);
        }
    }
    class Builder : IDeveloper, IComparable<IDeveloper>
    {
        string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }

        public Builder(string tool)
        {
            this.tool = tool;
        }
        public void Create()
        {
            Console.WriteLine("Create program with tool: {0}", tool);
        }
        public void Destroy()
        {
            Tool = tool;
            Console.WriteLine("Destroy program with tool: {0}", Tool);
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return string.Compare(this.Tool, other.Tool);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task1");
            List<IDeveloper> list = new List<IDeveloper>
            {
                new Programmer("language 1"),
                new Programmer("language 2"),
                new Builder("tool 2"),
                new Builder("tool 1"),
                new Programmer("language 3"),
                new Builder("tool 3")
            };
            foreach (var item in list)
            {
                item.Create();
                item.Destroy();
            }
            foreach (var item in list)
            {

                Console.WriteLine(item.CompareTo(list[1]));
            }

            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item.GetType());
                item.Create();
                item.Destroy();
            }

            Console.WriteLine("task2");
            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            for (uint i = 0; i < 7; i++)
            {
                uint id = Convert.ToUInt32(Console.ReadLine());
                string name = Console.ReadLine();
                persons[id] = name;
            }
            Console.WriteLine("write ID dictionary");
            uint idDictionary = Convert.ToUInt32(Console.ReadLine());
            if (persons.ContainsKey(idDictionary))
            {
                Console.WriteLine(persons[idDictionary]);
            }
            else
            {
                Console.WriteLine("Dictionary hasn`t this id");
            }

        }
    }
}
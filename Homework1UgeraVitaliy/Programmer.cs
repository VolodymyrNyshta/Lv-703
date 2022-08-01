using System;

namespace Homework5
{
    internal class Programmer : IDeveloper
    {
        public string language;
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }
        public Programmer(string tool)
        {
            this.language = tool;
        }
        public int CompareTo(IDeveloper other)
        {
            return this.Tool.CompareTo(other.Tool);
        }
        public void Create()
        {
            Console.WriteLine("Created : {0}", this.Tool);
        }
        public void Destroy()
        {
            Console.WriteLine("Destroyed : {0}, but just in words", this.Tool);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Programmer : IDeveloper
    {
        private string language;

        int IComparable<IDeveloper>.CompareTo(IDeveloper obj)
        {
            return string.Compare(this.Tool, obj.Tool);
        }
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
            Console.WriteLine($"Programmer create with {Tool}");
        }
        public void Destroy()
        {
            Console.WriteLine($"Programmer destroy with {Tool}");
        }
    }
}

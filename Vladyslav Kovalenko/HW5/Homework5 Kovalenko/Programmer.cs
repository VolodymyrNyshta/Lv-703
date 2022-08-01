using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Kovalenko
{
    internal class Programmer : IDeveloper
    {
        private string _language;
        public string Tool
        {
            get { return _language; }
            set { _language = value; }
        }
        public Programmer(string language)
        {
            this.Tool = language;
            
        }
        public void Create()
        {
            Console.WriteLine($"Programmer create {Tool}");
        }
        public void Destroy()
        {
            Console.WriteLine($"Programmer destroy {Tool}");
        }
        public int CompareTo(IDeveloper other)
        {
            return string.Compare(Tool, other.Tool);
        }

    }
}

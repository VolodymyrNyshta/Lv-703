using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Programmer : IDeveloper, IComparable
    {
        public string language;
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
            Console.WriteLine($"Method Create() for Programmer {language}");
        }
        public void Destroy()
        {
            Console.WriteLine($"Method Destroy() for Programmer {language}");
        }
        public int CompareTo(object o)
        {
            Builder b = o as Builder;
            Programmer p = o as Programmer;
            if (b != null)
                return this.Tool.CompareTo(b.Tool);
            else if (p != null)
                return this.Tool.CompareTo(p.Tool);
            else
                throw new ArgumentException("Object is not a developer");
        }
    }
}
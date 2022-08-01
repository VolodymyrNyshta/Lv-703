using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Builder : IDeveloper, IComparable
    {
        public string tool;
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
            Console.WriteLine($"Method Create() for Builder {tool}");
        }
        public void Destroy()
        {
            Console.WriteLine($"Method Destroy() for Builder {tool}");
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
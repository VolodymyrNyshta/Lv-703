using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Builder : IDeveloper
    {
        private string tool;

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return string.Compare(this.Tool,other.Tool);
        }
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
            Console.WriteLine($"Builder create with {tool}");
        }
        public void Destroy()
        {
            Console.WriteLine($"Builder destroy with {tool}");
        }
    }
}

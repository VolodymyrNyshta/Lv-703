using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Kovalenko
{
    internal class Builder : IDeveloper
    {
        private string _tool;
        public string Tool
        {
            get { return _tool; }
            set { _tool = value; }
        }
        public Builder(string tool)
        {
            this.Tool = tool;
        }

        public void Create()
        {
            Console.WriteLine($"Builder create {Tool}");
        }
        public void Destroy()
        {
            Console.WriteLine($"Builder destroy {Tool}");
        }
        public int CompareTo(IDeveloper other)
        {
            return string.Compare(Tool, other.Tool);
        }
    }

}

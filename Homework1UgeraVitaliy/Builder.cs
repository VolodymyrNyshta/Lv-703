using System;

namespace Homework5
{
    internal class Builder : IDeveloper
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

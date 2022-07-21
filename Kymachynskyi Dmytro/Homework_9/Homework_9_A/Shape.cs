using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_A
{
    public abstract class Shape
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();
        public abstract void Print();
        public abstract string OutputToString();

    }
}
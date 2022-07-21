using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    public abstract class Shape : IComparable
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
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentException("Object is not the shape!");
            }
            Shape otherShape = obj as Shape;
            return this.Area().CompareTo(otherShape.Area());
        }
    }
}

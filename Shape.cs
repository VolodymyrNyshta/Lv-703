using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Homework8
{
    abstract class Shape: IComparable<Shape>
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        public Shape(string name)
        {
            this.name = name;
        }
        abstract public double Area();
        abstract public double Perimeter();

        public int CompareTo([AllowNull] Shape other)
        {
            if (this.Area() > other.Area())
            { return 1; }
            else if (this.Area() < other.Area())
            { return -1; }
            else
                return 0;
            }
        }
    }


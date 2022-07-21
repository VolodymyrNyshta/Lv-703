using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW9_Kovalenko
{

    internal abstract class Shape : IComparable<Shape>
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Primeter();
        public int CompareTo(Shape? other)
        {
            if (this.Area() > other.Area())
            {
                return 1;
            }
            else if (this.Area() < other.Area())
            {
                return -1;
            }
            else
                return 0;
        }

    }

}

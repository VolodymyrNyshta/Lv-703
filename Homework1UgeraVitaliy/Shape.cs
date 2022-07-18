using System;
using System.Collections.Generic;

namespace Homework8
{
    abstract class Shape : IComparable<Shape>
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
        abstract public double Area();
        abstract public double Perimeter();
        public int CompareTo(Shape otherShape)
        {
            return Area().CompareTo(otherShape.Area());
        }
        public static void SortByArea(List<Shape> shapes)
        {
            int valueToReturn = 0;
            int outer, inner;
            for (outer = shapes.Count - 1; outer >= 0; outer--)
            {
                for (inner = 1; inner <= outer; inner++)
                {
                    valueToReturn = shapes[inner].CompareTo(shapes[inner - 1]); //value that defines whether current shape has Area that is greater, lesser or equals to other one
                    if (valueToReturn == -1)//means that current Area preseds other in the sort order
                    {
                        var temp = shapes[inner - 1];
                        shapes[inner - 1] = shapes[inner];
                        shapes[inner] = temp;
                    }
                }
            }
        }
    }
}

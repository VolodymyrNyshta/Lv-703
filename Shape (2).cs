using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace Homework8
{
    [DataContract]
    [Serializable]
     public abstract class Shape: IComparable<Shape>
    {
        private string name;
        [DataMember]
        [XmlAttribute]
        public string Name { get { return name; } set { name = value; } }
        public Shape() { }

        public Shape(string name)
        {
            this.name = name;
        }
        abstract public double Area();
        abstract public double Perimeter();

        public override string ToString()
        {
            return new string($"Name: {name}");
        }

        public void PrintToFile(StreamWriter stream)
        {
            stream.WriteLine($"Name: {name}");
        }
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


using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Homework8
{
    [DataContract]
    [Serializable]
    public class Square :Shape
    {
        private double side;
        [DataMember]
        [XmlAttribute]
        public double Side { get { return side; } set { side = value; } }
        public Square() { }
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return Math.Pow(side, 2);
        }
        public override double Perimeter()
        {
            return side * 2;
        }
        
    }
}

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
    public class Circle : Shape
    {
        private double radius;
        [DataMember]
        [XmlAttribute]
        public double Radius { get { return radius;  } set { radius = value; } }
        public Circle() { }
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Math.Pow(radius, 2);
        }
    }
}

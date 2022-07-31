using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string path = @"C:\Users\V\Desktop\SoftServe\test.txt";
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square("Square_A", 2));
            shapes.Add(new Square("Square_B", 8));
            shapes.Add(new Square("Square_C", 6));
            shapes.Add(new Square("Square_D", 4));
            shapes.Add(new Circle("Circle_A", 9));
            shapes.Add(new Circle("Circle_B", 7));
            shapes.Add(new Circle("Circle_C", 5));
            shapes.Add(new Circle("Circle_D", 3));

            //=========================================
            IEnumerable<Shape> query = shapes.Where(x => x.Area() > 10 && x.Area() < 100);
            try
            {
                using (StreamWriter sr = new StreamWriter(path))
                {
                    foreach (Shape item in query)
                    {
                        item.PrintToFile(sr);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //==========================================
            IEnumerable<Shape> query2 = from s in shapes
                                        where s.Name.ToLower().Contains('a')
                                        select s;
            try
            {
                using (StreamWriter sr = new StreamWriter(path))
                {
                    foreach (Shape item in query2)
                    {
                        item.PrintToFile(sr);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //=========================================================

            IEnumerable<Shape> query3 = from s in shapes
                                        where s.Perimeter() > 5
                                        select s;
            shapes.RemoveAll(x => x.Perimeter() < 5);
            foreach (Shape item in shapes)
            {
                Console.WriteLine(item.Perimeter());
            }

            foreach (Shape item in query3)
            {
                Console.WriteLine(item);
            }

            //=======================Binary Serialize==================================
            Console.WriteLine("============Binary Serialize==============");
            Circle circle = new Circle("FirstCirce", 5);

            BinaryFormatter formater = new BinaryFormatter();
            FileStream stream = new FileStream("BinarySerialize.bin", FileMode.Create, FileAccess.Write);
            formater.Serialize(stream, circle);
            stream.Close();

            FileStream stream1 = new FileStream("BinarySerialize.bin", FileMode.Open, FileAccess.Read);
            Circle circle1 = formater.Deserialize(stream1) as Circle;

            if (circle1 != null)
            {
                Console.WriteLine(circle1.Name);
            }
            stream1.Close();

            //=======================XML Serialize==================================
            Console.WriteLine("============XML Serialize==============");
            Square square = new Square("FirstSquare", 4);

            XmlSerializer xmlSerializer = new XmlSerializer(square.GetType());
            
            FileStream stream2 = new FileStream("XMLSerialize.xml", FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(stream2, square);
            stream2.Close();

            FileStream stream3 = new FileStream("XMLSerialize.xml", FileMode.Open, FileAccess.Read);
            Square square1 = xmlSerializer.Deserialize(stream3) as Square;
            if (square1 != null)
            {
                Console.WriteLine(square1.Name);
            }
            stream3.Close();

            //=======================JSON Serialize==================================
            Console.WriteLine("============JSON Serialize==============");

            Square square2 = new Square("SecondSquare", 8);
            DataContractSerializer dataContract = new DataContractSerializer(square2.GetType());

            Stream stream4 = new FileStream("JSONSerialize.json", FileMode.Create, FileAccess.ReadWrite);
            dataContract.WriteObject(stream4, square2);
            //stream4.Close();

            stream4.Position = 0;
            Square square3 = dataContract.ReadObject(stream4) as Square;
            if (square3 != null)
            {
                Console.WriteLine(square3.Name);
                Console.WriteLine(square3.Side);
            }
            stream4.Close();
        }
    }
}

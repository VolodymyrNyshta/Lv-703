using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myColl = new List<int>();
            for (int i = 0; i < 10; i++)
                myColl.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\nChecking list for element -10...");
            bool checkFlag = false;
            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    Console.WriteLine($"-10 found at {i + 1} position");
                    checkFlag = true;
                }
            }
            if (!checkFlag) Console.WriteLine("Value -10 not found.");
            Console.WriteLine("\nSearching and removing elements, which a greater 20...");
            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] > 20)
                {
                    myColl.RemoveAt(i);
                    i--;
                }
            }
            foreach (int i in myColl) Console.WriteLine(i);
            Console.WriteLine("\nInserting new elements...");
            const int addPos_1 = 1;
            const int addVal_1 = 1;
            const int addPos_2 = 7;
            const int addVal_2 = -3;
            const int addPos_3 = 4;
            const int addVal_3 = -4;
            InsertElement(myColl, addPos_1, addVal_1);
            InsertElement(myColl, addPos_2, addVal_2);
            InsertElement(myColl, addPos_3, addVal_3);
            foreach (int i in myColl) Console.WriteLine(i);
            Console.WriteLine("\nSorting elements...");
            myColl.Sort();
            foreach (int i in myColl) Console.WriteLine(i);
            Console.ReadKey();
        }
        public static void InsertElement(List<int> values, int position, int value)
        {
            if ((values.Count - position) >= 0)
            {
                values.Insert(position, value);
                Console.WriteLine($"Value {value} inserted at position #{position + 1}");
            }
            else Console.WriteLine($"Value {value} not inserted at position #{position + 1} due to short list length");
        }
    }
}

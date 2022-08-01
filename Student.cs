using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Homework11
{
     public delegate void MyDel(int m);

    class Accountancy : Student
    {
    public void PayingFellowship(int mark)
        {
            marks.Add(mark);
            if (marks.Average() < 71)
            {
                Console.WriteLine("Can't resive");
            }
            else
            {
                Console.WriteLine("Congratulation");
            }

        }
    }
    class Parent : Student
    { 
        public void ResiveMessage(int mark)
        {
        Console.WriteLine($"Your sun get new mark {mark}");
        }
         
    }

    class Student
    {
        private string name;
        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }
        public List<int> marks =new List<int>();

        private MyDel markChange;
        
        public event MyDel MarkChange 
        {
            add 
            {
                if (value!=null)
                {
                    markChange += value;
                    Console.WriteLine();
                }
            }
            remove
            {
                markChange -= value;
            }
         }

        public void AddMark(int x)
        {
            marks.Add(x);
            if (markChange != null)
            markChange.Invoke(x);
        }
    }
}

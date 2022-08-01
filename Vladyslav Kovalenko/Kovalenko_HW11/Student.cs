using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kovalenko_HW11
{
    public delegate void MyDel(int f);
    internal class Student
    {
        string name;
        public string Name { get { return this.name = "Pavlo"; } }
        public List<int> marks = new List<int>();
        public event MyDel MarkChange;
        public void AddMark(int newMark)
        {
            marks.Add(0);
            if (MarkChange != null)
                MarkChange.Invoke(newMark);
        }
    }
}

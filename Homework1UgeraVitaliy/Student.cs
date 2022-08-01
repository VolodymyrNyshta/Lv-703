using System.Collections.Generic;

namespace Homework11
{
    public class Student
    {
        public delegate void MyDel(int m);
        public event MyDel MarkChange;

        public static string mainName;//there were some problems with name and marks output so I added here static fields 
        public static List<int> mainList = new List<int>();

        private string name;
        public List<int> marks = new List<int>();
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<int> Marks
        {
            get { return marks; }
        }
        public void AddMark(int mark)
        {
            Marks.Add(mark);
            if (MarkChange != null)
            {
                MarkChange.Invoke(mark);
            }
        }
        public void AddToMainList(int mark)
        {
            mainList.Add(mark);
        }
    }
}

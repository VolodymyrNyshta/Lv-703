using System;

namespace Homework11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Parent parent = new Parent();
            Console.Write("Write student name: ");
            student.Name = Console.ReadLine();
            Student.mainName = student.Name;
            student.MarkChange += parent.OnMarkChange;
            Console.Write("How many marks to add: ");
            int toAdd = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < toAdd; i++)
            {
                Console.Write("Mark {0}: ", i + 1);
                int mark = Convert.ToInt32(Console.ReadLine());
                if (i != toAdd - 1)
                {
                    student.AddToMainList(mark);
                    student.AddMark(mark);
                }
                else
                {
                    Accountancy accountancy = new Accountancy();
                    student.MarkChange += accountancy.PayingFellowship;
                    student.AddMark(mark);
                }
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace Homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();

            MyDel del1 = parent.ResiveMessage;
            MyDel del2 = accountancy.PayingFellowship;
            student.MarkChange += del1;
            student.MarkChange += del2;
            student.AddMark(71);
            student.AddMark(65);
            student.AddMark(71);
            student.AddMark(90);

            student.MarkChange -= del1;
            student.AddMark(68);
        }
    }
}

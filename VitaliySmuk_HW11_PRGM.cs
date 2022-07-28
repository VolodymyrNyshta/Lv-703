namespace VitaliySmuk_HW_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Parent parent = new Parent();
            Accountancy scholarship = new Accountancy();
            MyDel mark = parent.OnMarkChange;
            MyDel s_Sh = scholarship.PayingScholarship;
            student.MarkChange += mark;
            student.MarkChange += s_Sh;
            student.AddMark(7);
            student.AddMark(77);
            student.AddMark(34);
            student.AddMark(90);
            student.AddMark(99);
        }
    }
}
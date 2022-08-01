namespace Kovalenko_HW11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent father = new Parent();
            Student student = new Student();
            Buhgalteria stipuha = new Buhgalteria();

            MyDel s = stipuha.Stupendiya;
            MyDel f = father.OnMarkChange;

            student.MarkChange += f;
            student.MarkChange += s;

            student.AddMark(51);
            student.AddMark(51);
            student.AddMark(88);
            student.AddMark(51);
            student.AddMark(51);
            student.AddMark(59);
            student.AddMark(51);
            Console.ReadKey();


        }
    }
}
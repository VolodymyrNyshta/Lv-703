namespace HW_4_Kovalenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Tom", 1980);
            Person[] person = new Person[6];
            for (int i = 1; i < person.Length; i++)
            {
                person[0] = person1;
                person[i] = Person.Input(i);
            }
            for (int i = 0; i < person.Length; i++)
            {
                person[i].Age();
                person[i].ChangeName();
                person[i].Output();
            }
            for(int i = 0; i < person.Length; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    if (person[i] == person[j])
                    { Console.WriteLine($"person {i} same names person {j}"); }
                }
            }

        }
    }
}

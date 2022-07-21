using System;

namespace HomeWork_
{
    class Cat
    {
       public enum Food : byte
        { 
        maus=1,
        fish=3,
        meat=5,
        }
        public byte SatietyLevel { get; set;}

        public void EatSomething(Food somefood)
        {
            SatietyLevel = (byte)somefood;
        }
        public override string ToString()
        {
            return string.Format($"SatietyLevel is: {SatietyLevel}");
        }
    }
    class Program
    {
        struct Student
        {
            string surname;
            int groupNumber;

            public Student(string surname, int groupNumber)
            {
                this.surname = surname;
                this.groupNumber = groupNumber;
            }
            public static void FindStudentByFirstLetter(Student[] studentsarray, char letter)
            {
                for (int i = 0; i < studentsarray.Length; i++)
                {
                    if (studentsarray[i].surname[0] == letter)
                    {
                        Console.WriteLine(studentsarray[i].surname);
                    }

                }
            }
        }
        struct Dog
        {
            string name;
            string mark;
            byte age;

            public Dog(string name, string mark, byte age)
            {
                this.name = name;
                this.mark = mark;
                this.age = age;
            }
            public override string ToString()
            {
                return string.Format($"Your dog: \nName is: {name}\nMark is: {mark}\nAge is: {age}");
            }
        }
        enum HTTPErors: int
        { 
       	BadRequest = 400,
	    Unauthorized,
	    PaymentRequired,
	    Forbidden,
	    NotFound,
	    MethodNotAllowed
        }
        public static void GetError(int errorNumber)
        { 
        switch(errorNumber)
            {
                case (int)HTTPErors.BadRequest:
                    Console.WriteLine($"Name your error is: {HTTPErors.BadRequest}");
                    break;
                case (int)HTTPErors.Forbidden:
                    Console.WriteLine($"Name your error is: {HTTPErors.Forbidden}");
                    break;
                case (int)HTTPErors.MethodNotAllowed:
                    Console.WriteLine($"Name your error is: {HTTPErors.MethodNotAllowed}");
                    break;
                case (int)HTTPErors.NotFound:
                    Console.WriteLine($"Name your error is: {HTTPErors.NotFound}");
                    break;
                case (int)HTTPErors.PaymentRequired:
                    Console.WriteLine($"Name your error is: {HTTPErors.PaymentRequired}");
                    break;
                case (int)HTTPErors.Unauthorized:
                    Console.WriteLine($"Name your error is: {HTTPErors.Unauthorized}");
                    break;
                default:
                    Console.WriteLine("Unnown error!");
                    break;


            }

        }
        static void Main(string[] args)
        {  
            //Task 1
            Console.WriteLine("Enter three float digit");
            Console.Write("a : ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("\nb : ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("\nc : ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine(((a > -5 && a < 5) && (b > -5 && b < 5) && (c > -5 && c < 5)) ? "They all in range" : "They not in range");
            Console.WriteLine(new string('*', 15));

            //Task 2
            Console.WriteLine("Enter three integer digit");
            Console.Write("x : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("\ny : ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("\nz : ");
            int z = int.Parse(Console.ReadLine());
            Console.Write("min = ");
            Console.WriteLine(((x < y) && (x < z)) ? x : ((y < x) && (y < z)) ? y : z);
            Console.Write("max = ");
            Console.WriteLine(((x > y) && (x > z)) ? x : ((y > x) && (y > z)) ? y : z);
            Console.WriteLine(new string('*', 15));

            //Task 3
            Console.WriteLine("Enter number of HTTP Error");
            int error = int.Parse(Console.ReadLine());
            GetError(error);
            Console.WriteLine(new string('*', 15));

            //Task 4
            Console.WriteLine("Enter dog name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter dog mark");
            string mark = Console.ReadLine();
            Console.WriteLine("Enter dog age");
            byte age = byte.Parse(Console.ReadLine());
            Dog myDog = new Dog(name, mark, age);
            Console.WriteLine(myDog);
            Console.WriteLine(new string('*', 15));

            //Task 5
            Cat myCat = new Cat();
            Cat.Food someFood = Cat.Food.meat;
            myCat.EatSomething(someFood);
            Console.WriteLine(myCat);

            //Task 6
            Student[] students = new Student[] { new Student("Zalyznyi", 1), new Student("Kozak", 2), new Student("Kohut", 3), new Student("Rybak", 4) };
            Student.FindStudentByFirstLetter(students, 'K');


            Console.ReadKey();
        }
    }
}

using System;

namespace Homework2
{
    internal class Program
    {
        // declaration of the enum HTTPError for the 3th task.
        public enum HTTPError
        {
            BadRequst = 400,
            Unauthorized,
            PaymentRequired,
            Forbidden,
            NotFound,
            MethodNotAllowed
        }
        // declaration of the struct Dog from the 4th task.
        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public override string ToString()
            {
                return string.Format($"This is {name}. It's mark is {mark} and it's {age}.");
            }
        }
        // declaration of the enum Food and the class Cat from the 5th task.
        enum Food
        {
            milk = 1,
            eggs,
            mouse,
            fish,
            meat
        }
        class Cat
        {
            private int levelOfSatiety;
            public Cat()
            {
                levelOfSatiety = 0;
            }
            public Cat(int levelOfSatiety)
            {
                this.levelOfSatiety = levelOfSatiety;
            }
            public void EatSomething(Food food)
            {
                switch (food)
                {
                    case Food.milk:
                        Console.WriteLine($"You've chosen to give {food} to the cat.");
                        levelOfSatiety += (int)food;
                        break;
                    case Food.eggs:
                        Console.WriteLine($"You've chosen to give {food} to the cat.");
                        levelOfSatiety += (int)food;
                        break;
                    case Food.mouse:
                        Console.WriteLine($"You've chosen to give {food} to the cat.");
                        levelOfSatiety += (int)food;
                        break;
                    case Food.fish:
                        Console.WriteLine($"You've chosen to give {food} to the cat.");
                        levelOfSatiety += (int)food;
                        break;
                    case Food.meat:
                        Console.WriteLine($"You've chosen to give {food} to the cat.");
                        levelOfSatiety += (int)food;
                        break;
                    default:
                        Console.WriteLine("Enter correct number!\n");
                        break;
                }
            }
            public override string ToString()
            {
                return String.Format($"The level of satiety of cat equals: {levelOfSatiety}");
            }
        }
        // declaration of the struct Student from the 6th task.
        struct Student
        {
            public int groupNumber;
            public string studentSurname;

            public Student(string surname, int group)
            {
                groupNumber = group;
                studentSurname = surname;
            }
            public override string ToString()
            {
                return String.Format($"Surname: {studentSurname}, group: {groupNumber}.");
            }
            public void EnterSurname()
            {
                Console.WriteLine("Enter the student's surname");
                studentSurname=Console.ReadLine();
            }
            public void EnterGroup()
            {
                Console.WriteLine("Enter the student's group");
                groupNumber = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            // Task 1. Read 3 float numbers and check if they are all in the range [-5.5].
            float num1, num2, num3;
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            num3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(((num1 <= 5) && (num1 >= -5)) && ((num2 <= 5) && (num2 >= -5)) && ((num3 <= 5) && (num3 >= -5)) ?
                "All of them are in the rangle [-5;5]" : "All of them are not in range [-5;5]");

            // Task 2. Read 3 integer numbers and output max and min of them.
            int A, B, C;
            Console.WriteLine("Enter the A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the C");
            C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((A >= B) && (A >= C) ? "The number A is max."
                : ((B >= C) && (B >= A)) ? "The number B is max."
                : "The number C is max.");

            // Task 3. Read number of HTTP Error (400, 401,402, ...) and write the name of this error 
            Console.WriteLine("Enter the number of HTTP error:");
            int error;
            error = Convert.ToInt32(Console.ReadLine());
            switch ((HTTPError)error)
            {
                case HTTPError.BadRequst:
                    Console.WriteLine("Name of error: Bad Request.");
                    break;
                case HTTPError.Unauthorized:
                    Console.WriteLine("Name of error: Unauthorized.");
                    break;
                case HTTPError.PaymentRequired:
                    Console.WriteLine("Name of error: Payment Required.");
                    break;
                case HTTPError.Forbidden:
                    Console.WriteLine("Name of error: Forbidden.");
                    break;
                case HTTPError.NotFound:
                    Console.WriteLine("Name of error: Not Found.");
                    break;
                case HTTPError.MethodNotAllowed:
                    Console.WriteLine("Name of error: Method not allowed.");
                    break;
                default:Console.WriteLine("Enter correct code of HTTP error.");
                    break;
            }
            // Task 4. Declare struct Dog with fields name, mark, age.
            // Declare object myDog of Dog type and read values for it.
            // Output information on the console. (Override method ToString in struct)
            Dog myDog;
            Console.WriteLine("Enter the dog's name:");
            myDog.name = Console.ReadLine();
            Console.WriteLine("Enter the dog's mark:");
            myDog.mark = Console.ReadLine();
            Console.WriteLine("Enter the dog's age:");
            myDog.age = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(myDog);

            // Task 5. Створіть клас Cat.
            // У кішки буде властивість «рівень ситості» і метод «з'їсти щось».
            // Створіть enum Їжа (риба, миша ...).
            // Кожен вид їжі повинен по-різному змінювати рівень ситості.
            Cat Kitty;
            Kitty = new Cat();
            Console.WriteLine("Food for cat that is available:\n1.Milk\n2.Eggs\n3.Mouse\n4.Fish\n5.Meat");
            Console.WriteLine("Enter what you want to give to the cat:");
            Food food = (Food)Convert.ToInt32(Console.ReadLine());
            Kitty.EatSomething(food);
            Console.WriteLine(Kitty);

            // Task 6. Створити структуру Студент з прізвищем студента та номером його групи.
            // Сформувати і вивести масив з прізвищ студентів заданої групи, що починаються на задану букву.
            // Прізвище та номер групи вводяться з консолі.
            Student[] Students;
            Console.WriteLine("Enter the number of students:");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            Students = new Student[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                Students[i] = new Student();
                Students[i].EnterSurname();
                Students[i].EnterGroup();
            }
            Console.WriteLine("Enter the first letter: ");
            char letter = Convert.ToChar(Console.ReadLine());
            Student[] StudentsWithEnteredLetter; // array that stores students, who have surnames beginning with the letter entered by user.
            int numOfSurnamesWithLetter = 0; // variable that stores the number of surnames with the letter entered by user.
            for (int i = 0; i < numberOfStudents; i++)
            {
                // We ckeck if the first letter of the student's surname is the same as the letter entered by user.
                // Then we count the number of surnames with that letter and create an array of that size.
                if (Students[i].studentSurname[0] == letter)
                {
                    numOfSurnamesWithLetter++;
                }
            }
            if (numOfSurnamesWithLetter != 0)
            {
                StudentsWithEnteredLetter = new Student[numOfSurnamesWithLetter];
                int j = 0; // variable for iteration in array with students who have surnames beginning with entered letter.
                for (int i = 0; i < numberOfStudents; i++)
                {
                    if (Students[i].studentSurname[0] == letter)
                    {
                        StudentsWithEnteredLetter[j] = Students[i];
                        j++;
                    }
                }
                Console.WriteLine($"The lisk of students whose surnames begin with {letter}: ");
                for (int i = 0; i < numOfSurnamesWithLetter; i++)
                {
                    Console.WriteLine(StudentsWithEnteredLetter[i]);
                }
            }
            else Console.WriteLine("The list is empty.\n");
        }
    }
}

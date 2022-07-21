using System;
using System.Linq;

namespace HW2SoftServe
{
    enum Food
    {
        Fish = 2,
        Meat = 5,
        Milk,
        Mouse = 8
    }
    class Cat
    {
        public int SatietyLevel { get; set; }
        public Food EatSomething { get; set; }

        public override string ToString()
        {
            return string.Format("Satiety level: {0}", SatietyLevel);
        }

    }
    class Program
    {
        struct Student
        {
            public string surname;
            public int numGroup;
            public override string ToString()
            {
                return string.Format("Surname: {0}, number group: {1}", surname, numGroup);
            }
        }
        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public override string ToString()
            {
                return string.Format("Name: {0}, mark: {1}, age: {2}", name, mark, age);
            }
        }
        enum HTTPError
        {
            BadRequest = 400,
            Unathorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404
        }
        static void Main(string[] args)
        {
            Console.WriteLine("task1");

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if ((c >= -5 && c <= 5) && (b >= -5 && b <= 5) && (a >= -5 && a <= 5))
            {
                Console.WriteLine($"a: {a}, b: {b}, c: {c}");
            }
            else
                Console.WriteLine("One(several) of the numbers are not in range [-5,5]");

            Console.WriteLine("task2");

            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max num: {0}", Math.Max(a1, Math.Max(b1, c1)));
            Console.WriteLine("Min num: {0}", Math.Min(a1, Math.Min(b1, c1)));


            Console.WriteLine("Task3");

            Console.WriteLine("Write number of error 400-404");
            int error = Convert.ToInt32(Console.ReadLine());
            if (error == 400)
            {
                Console.WriteLine("HTTPError" + HTTPError.BadRequest);
            }
            else if (error == 401)
            {
                Console.WriteLine("HTTPError" + HTTPError.Unathorized);
            }
            else if (error == 402)
            {
                Console.WriteLine("HTTPError" + HTTPError.PaymentRequired);
            }
            else if (error == 403)
            {
                Console.WriteLine("HTTPError" + HTTPError.Forbidden);
            }
            else if (error == 404)
            {
                Console.WriteLine("HTTPError" + HTTPError.NotFound);
            }
            else
                Console.WriteLine("Number must have 400-404");

            Console.WriteLine("Task 4");
            Dog myDog = new Dog { name = "rob", mark = "labrador", age = 10 };
            Console.WriteLine(myDog);

            Console.WriteLine("Additional task 1");
            Cat cat1 = new Cat();
            cat1.EatSomething = Food.Milk;
            if (cat1.EatSomething == Food.Fish)
            {
                cat1.SatietyLevel = (int)Food.Fish;
            }
            else if (cat1.EatSomething == Food.Meat)
            {
                cat1.SatietyLevel = (int)Food.Meat;
            }
            else if (cat1.EatSomething == Food.Milk)
            {
                cat1.SatietyLevel = (int)Food.Milk;
            }
            else if (cat1.EatSomething == Food.Mouse)
            {
                cat1.SatietyLevel = (int)Food.Mouse;
            }
            Console.WriteLine(cat1);

            Console.WriteLine("Additional task 2");

            int n = Convert.ToInt32(Console.ReadLine());
            Student[] mass = new Student[n];
            for (int i = 0; i < n; i++)
            {
                mass[i].surname = Console.ReadLine();
                mass[i].numGroup = Convert.ToInt32(Console.ReadLine());
            }
            var t = from x in mass
                    where x.surname.StartsWith("A") && x.numGroup == 2
                    select x;
            foreach (var item in t)
            {
                Console.WriteLine(item);
            }
        }
    }
}
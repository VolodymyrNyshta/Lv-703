using System;
using System.Linq;
using System.Collections.Generic;

namespace Homework2
{
    internal class Program
    {
        enum HTTPError
        {
            Bad_Request = 400,
            Not_Found = 404,
            Gateway_Timeout = 504,
            Internal_Server_Error = 505
        }
        
        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public override string ToString()
            {
                return string.Format($"Dog's desciption:\n name - {name},\n mark - {mark},\n age - {age}" );
            }
        }

        static void Main(string[] args)
        {
            //Homework2Part1
            const string IN_THE_RANGE = "in the range [-5;5]";
            const string OUT_OF_THE_RANGE = "out of the range [-5;5]";
            const string VARIABLE_N1 = "\tVariable {0} is " + IN_THE_RANGE; //when the variable is in the range
            const string VARIABLE_N2 = "\tVariable {0} ({1}) is " + OUT_OF_THE_RANGE; //when the variable is out of the range
            Console.Write("Write the first(a) float number : ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Write the second(b) float number : ");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Write the third(c) float number : ");
            float c = Convert.ToSingle(Console.ReadLine());
            bool passedA = a < -5 && a > 5; //passed - is in range
            bool passedB = b < -5 && b > 5;
            bool passedC = c < -5 && c > 5;
            if (passedA && passedB && passedC)
            {
                Console.WriteLine("All numbers are {0}", IN_THE_RANGE);
            }
            else
            {
                Console.WriteLine("Not all numbers are {0}", IN_THE_RANGE);
                Console.WriteLine("  Description : ");
                if (passedA)
                {
                    Console.WriteLine(VARIABLE_N1, nameof(a), a);
                }
                else
                {
                    Console.WriteLine(VARIABLE_N2, nameof(a), a);
                }
                if (passedB)
                {
                    Console.WriteLine(VARIABLE_N1, nameof(b), b);
                }
                else
                {
                    Console.WriteLine(VARIABLE_N2, nameof(b), b);
                }
                if (passedC)
                {
                    Console.WriteLine(VARIABLE_N1, nameof(c), c);
                }
                else
                {
                    Console.WriteLine(VARIABLE_N2, nameof(c), c);
                }
            }



            //Homework2Part2
            Console.WriteLine("\nWrite your 3 integers : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            Console.WriteLine("\nOutput of max and min values : ");
            int max = list.Max();
            Console.WriteLine("Max value = {0}", max);
            int min = list.Min();
            Console.WriteLine("Min value = {0}", min);

            //Homework2Part3
            Console.Write("\nWrite the error's number : ");
            int error = Convert.ToInt32(Console.ReadLine());
            if (Enum.IsDefined(typeof(HTTPError), error))
            {
                Console.WriteLine("The name of the error is {0}\n", Enum.GetName(typeof(HTTPError), error));
            }
            else
            {
                Console.WriteLine("Error name is not found...");
            }

            //Homework2Part4
            Dog myDog = new Dog();
            Console.WriteLine("Write dog parameters (name, mark, age) : ");
            myDog.name = Console.ReadLine();
            myDog.mark = Console.ReadLine();
            myDog.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(myDog);
        }
    }
}

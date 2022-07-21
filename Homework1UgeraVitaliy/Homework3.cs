using System;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Homework3Part1
            Console.WriteLine("Target characters to find : 'a', 'o', 'i', 'e'");
            Console.Write("Enter your string : ");
            string str = Console.ReadLine();
            int sumOfCertainCharacters = 0;
            foreach (char item in str)
            {
                if (item == 'a' || item == 'o' || item == 'i' || item == 'e')
                {
                    sumOfCertainCharacters++;
                }
            }
            Console.WriteLine("There is {0} characters in the string.", sumOfCertainCharacters);
            int characterCounterOfA = 0;
            int characterCounterOfO = 0;
            int characterCounterOfI = 0;
            int characterCounterOfE = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    characterCounterOfA++;
                }
                else if (str[i] == 'o')
                {
                    characterCounterOfO++;
                }
                else if (str[i] == 'i')
                {
                    characterCounterOfI++;
                }
                else if (str[i] == 'e')
                {
                    characterCounterOfE++;
                }
            }
            Console.WriteLine("More detailed description :");
            Console.WriteLine("\tCount of 'a' character : {0}\n\tCount of 'o' character : {1}\n\tCount of 'i' character : {2}\n" +
                "\tCount of 'e' character : {3}\n", characterCounterOfA, characterCounterOfO, characterCounterOfI, characterCounterOfE);

            //Homework3Part2
            Console.WriteLine("Write your month and then the year (month has to be written in letters)...");
            Console.Write("Month : ");
            string month = Console.ReadLine();
            Console.Write("Year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime inputedYear = new DateTime(year, 1, 1);
            bool isLeapYear = DateTime.IsLeapYear(inputedYear.Year);
            if (isLeapYear)
            {
                Console.WriteLine("Written year is a leap year!");
            }
            else
            {
                Console.WriteLine("Written year is not a leap year!!!");
            }
            string monthDescripion = "There is {0} days in inputed month";
            switch (month.ToLower())
            {
                case "february":
                    if (isLeapYear)
                    {
                        Console.WriteLine(monthDescripion, 29);
                    }
                    else
                    {
                        Console.WriteLine(monthDescripion, 28);
                    }
                    break;
                case "april":
                case "june":
                case "september":
                case "november":
                    Console.WriteLine(monthDescripion, 30);
                    break;
                case "january":
                case "march":
                case "may":
                case "july":
                case "august":
                case "october":
                case "december":
                    Console.WriteLine(monthDescripion, 31);
                    break;
                default:
                    Console.WriteLine("Inputed month is incorrect!!!");
                    break;
            }

            //Homework3Part3
            const int N = 10;
            int[] arrayOfIntegers = new int[N];
            Console.WriteLine("\nEnter your integers in amount of 10 : ");
            for (int i = 0; i < N; i++)
            {
                arrayOfIntegers[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool checkIfSomeAreNegatives = false;
            for (int i = 0; i < N / 2; i++)
            {
                if (arrayOfIntegers[i] < 0)
                {
                    Console.WriteLine("Some of first 5 integers are negative!!!");
                    checkIfSomeAreNegatives = true;
                    break;
                }
            }
            if (checkIfSomeAreNegatives)
            {
                int product = 1;
                for (int i = N / 2; i < N; i++)
                {
                    product *= arrayOfIntegers[i];
                }
                Console.WriteLine("The product of last five integers is : {0}", product);
            }
            else
            {
                int sum = 0;
                Console.WriteLine("All of 5 first elements are positive!!!");
                for (int i = 0; i < N / 2; i++)
                {
                    sum += arrayOfIntegers[i];
                }
                Console.WriteLine("The sum of first five integers is : {0}", sum);
            }

            Console.ReadKey();
        }
    }
}

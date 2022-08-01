using System;
using System.Collections.Generic;

namespace Homework6
{
    internal class Program
    {
        static double Div(int firstNumber, int secondNumber)
        {
            return (double)firstNumber / secondNumber;
        }
        static void Main(string[] args)
        {
            //Homework6Part1
            Console.Write("Write the first integer value to divide : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write the second integer value to divide : ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (secondNumber == 0)
                {
                    throw new DivideByZeroException("You cannot divide by zero!!!");
                }
                else
                {
                    double result = Div(firstNumber, secondNumber);
                    Console.WriteLine("Result of dividing : {0}", result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine("\n\n");

            //Homework6Part2
            try
            {
                Console.Write("Write the first double value to divide : ");
                string s = Console.ReadLine();
                double firstDoubuleNumber, secondDoubleNumber;
                double firstOutValue;
                if (double.TryParse(s, out firstOutValue))
                {
                   firstDoubuleNumber = Convert.ToDouble(s);
                }
                else
                {
                    throw new FormatException("You sould probably use ',' instead of '.' as a decimal separator, or at least write only digits");
                }
                Console.Write("Write the second double value to divide : ");
                s = Console.ReadLine();
                double secondOutValue;
                if (double.TryParse(s, out secondOutValue))
                {
                    secondDoubleNumber = Convert.ToDouble(s);
                }
                else
                {
                    throw new FormatException("You sould probably use ',' instead of '.' as a decimal separator, or at least write only digits");
                }
                if (secondDoubleNumber == 0)
                {
                    throw new DivideByZeroException("You cannot divide by zero!!!");
                }
                else
                {
                    double result = firstDoubuleNumber / secondDoubleNumber;
                    Console.WriteLine("Result of dividing : {0}", result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine("\n\n");

            //Homework6Part3 - LiteVersion
            List<int> sequenceOfNumbers = new List<int>();
            Console.Write("First number of the sequence : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            sequenceOfNumbers.Add(number1);
            int temp = number1;
            while (sequenceOfNumbers.Count < 10)
            {
                try
                {
                    Console.Write("Next number : ");
                    int nextNumberToAdd = Convert.ToInt32(Console.ReadLine());
                    if (nextNumberToAdd <= temp)
                    {
                        throw new ApplicationException("Your sequence is not correct, try another number to input in there!!!");
                    }
                    else
                    {
                        sequenceOfNumbers.Add(nextNumberToAdd);
                        temp = nextNumberToAdd;
                    }
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Homework6Part3
            Console.WriteLine("\n\n");
            Console.WriteLine("Write start point and end point:");
            Console.Write("Start point : ");
            int startPoint = Convert.ToInt32(Console.ReadLine());
            Console.Write("End point : ");
            int endPoint = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>(10);
            Console.WriteLine("Write the sequence of 10 integers : ");
            for (int i = 0; i < numbers.Capacity;)
            {
                int readNumber = ReadNumber(startPoint, endPoint);
                if (readNumber != 0)
                {
                    numbers.Add(readNumber);
                    i++;
                }
                else
                {
                    Console.WriteLine("Write next number again...");
                }
            }

            Console.ReadKey();
        }

        static int ReadNumber(int start, int end)
        {
            Console.Write("Next value : ");
            try
            {
                string nextValue = Console.ReadLine();
                int valueToOut;
                if (int.TryParse(nextValue, out valueToOut))
                {
                    Console.WriteLine($"Value {nextValue} was converted into {valueToOut} successfully!");
                    int nextValueToRead = Convert.ToInt32(nextValue);
                    try
                    {
                        if (nextValueToRead > start && nextValueToRead < end)
                        {
                            if (nextValueToRead > PreviousNumber.previousNumberToRead)
                            {
                                PreviousNumber.previousNumberToRead = nextValueToRead;
                                return nextValueToRead;
                            }
                            else
                            {
                                throw new ApplicationException("Number is in wrong sequence!!!");
                            }
                        }
                        else
                        {
                            throw new ApplicationException("Number is out of the specified range!!!");
                        }
                    }
                    catch (ApplicationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    throw new FormatException("Inputed number has non-numerical type!!!");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
    }
}

using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            bool flag = false;
            do
            {
                try
                {
                    //Console.Write("a= ");
                    //int a = int.Parse(Console.ReadLine());
                    //Console.Write("b= ");
                    //int b = int.Parse(Console.ReadLine());

                    Console.Write("a= ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    double b = double.Parse(Console.ReadLine());
                    if (b == 0) 
                    {
                        flag = true;
                        throw new DivideByZeroException();
                    }
                    if (a < b)
                    {
                        flag = true;
                        throw new ApplicationException("b must be lower than a");
                    }

                    Console.WriteLine($"a/b={Div(a, b)}");
                    flag = false;
                }
                catch (DivideByZeroException)
                {
                    flag = true;
                    Console.WriteLine("Dividing by ziro forbiden");
                }
                catch (FormatException)
                {
                    flag = true;
                    Console.WriteLine("Bed argument");
                }
                catch (ApplicationException ex)
                {
                    flag = true;
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    Console.WriteLine("Nice");
                }
            } while (flag == true);
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }
    }
}

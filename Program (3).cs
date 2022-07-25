using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            do
            {
                flag = false;
                try
                {
                    Console.WriteLine("Enter constraint for sequence:");
                    Console.Write("Start = ");
                    int start = int.Parse(Console.ReadLine());
                    Console.Write("End = ");
                    int end = int.Parse(Console.ReadLine());
                    if (start > end)
                    {
                        flag = true;
                        throw new ApplicationException("Start can't be bigger than End");
                    }
                    if (end - start < 10)
                    {
                        flag = true;
                        throw new ApplicationException("Sequence must contain 10 number, you constraint don't allow this");
                    }
                    ReadNumber(start, end);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bad format");
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
               

            } while (flag);

            

        }
        public static void ReadNumber(int start = 1, int end = 100)
        {
            int pre = start;
            int next = end;

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine("Enter yuor numbers:");
                    int a = int.Parse(Console.ReadLine());
                    if (a <= pre || a >= next)
                    {
                        i--;
                        throw new ApplicationException($"Number must be beetwin {pre} and {next}");
                    }
                    else
                    {
                        pre = a;
                    }
                }
                catch (FormatException)
                {
                    i--;
                    Console.WriteLine("Bad format");
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("GoodLuck");
                }
            }
        }
    }
}

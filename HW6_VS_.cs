namespace HW6_VS
{
    internal class HW6_VS_
    {
        public static int Div(int a, int b)
        {
            return a / b;
        }
        public static void ReadNumber(int start, int end)
        {
        start:
            try
            {
                Console.WriteLine("Enter 10 int number");
                Console.WriteLine("Enter num1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                if (start > num1 || num1 > end) { throw new Exception("this num should be > than previous one or start num. Let's start again"); }
                Console.WriteLine("Enter num2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 > num2 || num2 > end) { throw new Exception("this num should be > than previous one or start num. Let's start again"); }
                Console.WriteLine("Enter num3");
                int num3 = Convert.ToInt32(Console.ReadLine());
                if (num3 < num2 || num3 > end) { throw new Exception("this num should be > than previous one or start num. Let's start again"); }
                Console.WriteLine("Enter num4");
                int num4 = Convert.ToInt32(Console.ReadLine());
                if (num4 < num3 || num4 > end) { throw new Exception("this num should be > than previous one or start num. Let's start again"); }
                Console.WriteLine("Enter num5");
                int num5 = Convert.ToInt32(Console.ReadLine());
                if (num5 < num4 || num5 > end) { throw new Exception("this num should be > than previous one or start num. Let's start again"); }
                Console.WriteLine("Enter num6");
                int num6 = Convert.ToInt32(Console.ReadLine());
                if (num6 < num5 || num6 > end) { throw new Exception("this num should be > than previous one or start num. Let's start again"); }
                Console.WriteLine("Enter num7");
                int num7 = Convert.ToInt32(Console.ReadLine());
                if (num7 < num6 || num7 > end) { throw new Exception("this num should be > than previous one or start num. Let's start again"); }
                Console.WriteLine("Enter num8");
                int num8 = Convert.ToInt32(Console.ReadLine());
                if (num8 < num7 || num8 > end) { throw new Exception("this num should be > than previous one or start num. Let's start again"); }
                Console.WriteLine("Enter num9");
                int num9 = Convert.ToInt32(Console.ReadLine());
                if (num9 < num8 || num9 > end) { throw new Exception("this num should be > than previous one or start num. Let's start again"); }
                Console.WriteLine("Enter num10");
                int num10 = Convert.ToInt32(Console.ReadLine());
                if (num10 < num9 || num10 > end) { throw new Exception("this num should be > than previous one or start num. Let's start again"); }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }

        }
        static void Main(string[] args)
        {
            //TASK 1
        start:
            try
            {
                Console.WriteLine("Please Enter two int numbers one by one");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                if (a < b) { throw new Exception("first number must be > tan the second one"); }
                Console.WriteLine($"{a}+{b}={Div(a, b)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }
            //TASK 2
            //IN CASE WE WILL BE WORKING WITH DOUBLE NUM,to call DivdeByZeroExeption we need to:
            //if (int b == 0) {throw new DivedeByZeroExeption()};
            Console.WriteLine();
        //TASK 3
        A1:
            try
            {
                Console.WriteLine("Enter int start");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter int end");
                int end = Convert.ToInt32(Console.ReadLine());
                if (start > end || end - start < 10) { throw new Exception("your start must be < than end and in their range must fit full 10 int num"); }
                ReadNumber(start, end);
                Console.WriteLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto A1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto A1;
            }
        }
    }
}
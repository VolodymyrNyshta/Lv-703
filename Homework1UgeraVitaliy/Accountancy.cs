using System;
using System.Linq;

namespace Homework11
{
    public class Accountancy
    {
        public void PayingFellowship(int mark)
        {
            double averageMark = Student.mainList.Average();
            if (averageMark >= 75)
            {
                Console.WriteLine("Average marks is: {0:F2}", averageMark);
                Console.WriteLine("Last mark: {0}", mark);
                Console.WriteLine("Student has a scholarship!");
            }
            else
            {
                Console.WriteLine("Average marks is: {0:F2}", averageMark);
                Console.WriteLine("Last mark: {0}", mark);
                Console.WriteLine("Student has no scholarship!");
            }
        }
    }
}

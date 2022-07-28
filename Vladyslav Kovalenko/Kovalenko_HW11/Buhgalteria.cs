using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kovalenko_HW11
{
    internal class Buhgalteria : Student
    {
        public void Stupendiya(int newMarks)
        {
            marks.Add(newMarks);
            if(marks.Average() > 71)
                Console.WriteLine($"Sturent {Name} will be fellowship");
            else
                Console.WriteLine($"Student {Name} not will be fellowship");
        }
    }
}

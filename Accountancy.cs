using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaliySmuk_HW_11
{
    internal class Accountancy : Student
    {
        public void PayingScholarship(int mark)
        {
            marks.Add(mark);
            if (marks.Average() <= 71)
            {
                Console.WriteLine($"We are sorry, but {Name} can't resive his Scholarship");
            }
            else
            {
                Console.WriteLine($"Our congrats {Name} will resive his Scholarship");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    public class Developer : Staff
    {
        private string level;
        public string Level { get { return level; } }
        public Developer(string firstName, string lastName, int personId, int salary, string level) 
            : base(firstName, lastName, personId, salary)
        {
            this.level = level;
        }
        public override void Print()
        {
            Console.WriteLine($"Developer: {FirstName} {LastName} Level:{level} ID:{PersonId} ${Salary}");
        }
        public override string OutputToString()
        {
            return $"Developer: {FirstName} {LastName} Level:{level} ID:{PersonId} ${Salary}";
        }
    }
}

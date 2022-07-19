using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    public class Teacher : Staff
    {
        private string subject;
        public string Subject { get { return subject; }  }
        public Teacher(string firstName, string lastName, int personId, int salary, string subject) 
            : base(firstName, lastName, personId, salary)
        {
            this.subject = subject;
        }
        public override void Print()
        {
            Console.WriteLine($"Teacher: {FirstName} {LastName} Subject:{Subject} ID:{PersonId} ${Salary}");
        }
        public override string OutputToString()
        {
            return $"Teacher: {FirstName} {LastName} Subject:{Subject} ID:{PersonId} ${Salary}";
        }

    }
}

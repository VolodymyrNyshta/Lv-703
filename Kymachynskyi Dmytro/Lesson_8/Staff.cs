using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    public class Staff : Person, IComparable<Staff>
    {
        private int salary;
        public int Salary { get { return salary; } }
        public Staff(string firstName, string lastName, int personId, int salary) : base(firstName, lastName, personId)
        {
            this.salary = salary;
        }
        public override void Print()
        {
            Console.WriteLine($"Staff: {FirstName} {LastName} ID:{PersonId} ${Salary}");
        }
        public override string OutputToString()
        {
            return $"Staff: {FirstName} {LastName} ID:{PersonId} ${Salary}";
        }
        public int CompareTo(Staff obj)
        {
            if (obj == null)
            {
                throw new ArgumentException("Object is not Staff!");
            }
            Staff other = obj as Staff;
            return this.Salary.CompareTo(other.Salary); 
        }
    }
}

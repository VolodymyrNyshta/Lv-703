using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    public abstract class Person : IComparable
    {
        private string firstName;
        private string lastName;
        private int personId;
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public int PersonId { get { return personId; } }
        public Person(string firstName, string lastName, int personId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.personId = personId;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Person: {this.firstName} {this.lastName} {this.personId}");
        }
        public virtual string OutputToString()
        {
            return $"Person: {this.firstName} {this.lastName} {this.personId}";
        }
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentException("Object is not Person!");
            }
            Person otherPerson = obj as Person;
            return this.FirstName.ToLower().CompareTo(otherPerson.FirstName.ToLower());
        }

    }
}

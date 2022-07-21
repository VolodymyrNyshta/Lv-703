using System;

namespace Homework4
{
    internal class Person
    {
        private string name;
        private DateTime birthYear;


        public string PersonName
        {
            get
            {
                return name;
            }
        }
        public int PersonBirthYear
        {
            get
            {
                return birthYear.Year;
            }
        }

        public Person()
        {

        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            return DateTime.Now.Year - birthYear.Year;
        }

        public void Input()
        {
            Console.Write("Write the person name : ");
            name = Console.ReadLine();
            Console.Write("Write the person birth year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            birthYear = new DateTime(year, 1, 1);
        }

        public void ChangeName(Person person)
        {
            if (person.Age() < 16)
            {
                person.name = "Very Young";
            }
        }

        public void ToChangeName(string name) //changes names which you want to change
        {
            Console.WriteLine("If you want to change someone's person name press 'Enter or 0', but if you don't want to do so, then press '1'");
            bool doItAgain = false; //the value for asking user again if there is a wrong 'Key' value
            do
            {
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        Console.WriteLine("The name to change : {0}", name);
                        Console.WriteLine("Write down the new name : ");
                        name = Console.ReadLine();
                        doItAgain = false;
                       break;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        doItAgain = false;
                        break;
                    default:
                        Console.WriteLine("Okay then! But try to enter the correct value!");
                        doItAgain = true;
                        break;
                }

            } while (doItAgain);
        }

        public override string ToString()
        {
            return "Person name : " + name + "\nPerson birth year : " + birthYear.Year;
        }

        public void Output(Person person)
        {
            string toOutput = person.ToString();
            Console.WriteLine(toOutput);
        }

        public static bool operator ==(Person first, Person second)
        {
            return first.name == second.name;
        }

        public static bool operator !=(Person first, Person second)
        {
            return !(first.name == second.name);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

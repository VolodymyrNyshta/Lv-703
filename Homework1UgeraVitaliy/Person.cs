using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Homework7
{
    internal class Person
    {
        private string name;
        private string phoneNumber;
        static readonly string path = @"G:\repository\VS2022\Homework7\Homework7\phones.txt";
        public string PersonName
        {
            get { return name; }
            set { name = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public Person()
        {

        }
        public Person(string name)
        {
            this.name = name;
        }
        public bool SetAndGetPersonName(string inputedName)
        {
            string[] lines = File.ReadAllLines(path);
            string names = string.Empty;
            bool nameDoesNotExist = true;
            foreach (string line in lines)
            {
                if (line.Length != 0)
                {
                    string[] substringElement;
                    substringElement = line.Split(',', ' ');
                    if (substringElement[1].ToLower() == inputedName.ToLower())
                    {
                        nameDoesNotExist = false;
                        string changedNameString = char.ToUpper(inputedName[0]) + inputedName.Substring(1);
                        PersonName = changedNameString;
                        break;
                    }
                    else
                    {
                        nameDoesNotExist = true;
                    }
                }
            }
            if (nameDoesNotExist)
            {
                Console.WriteLine("Your name does not exist in the current context!!!");
                return false;
            }
            else
            {
                Console.WriteLine("Your name is {0}", PersonName);
                return true;
            }
            
        }
        public void GetPersonPhone(Person person)
        {
            string[] lines = File.ReadAllLines(path);
            string names = string.Empty;

            foreach (string line in lines)
            {
                if (line.Length != 0)
                {
                    string[] substringElement;
                    substringElement = line.Split(',', ' ');
                    if (person.PersonName == substringElement[1])
                    {
                        PhoneNumber = substringElement[4];
                    }
                }
                
            }
            Console.WriteLine("Your phone number is {0}", PhoneNumber);
        }
        public string GetListOfPhones(Dictionary<string, string> phoneBook)
        {
            StringBuilder values = new StringBuilder("List of phone numbers:\n");
            foreach (KeyValuePair<string, string> item in phoneBook)
            {
                values.AppendLine(item.Value + ",");
            }
            return values.ToString();
        }
    }
}

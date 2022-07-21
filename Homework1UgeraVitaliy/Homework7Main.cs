using System;
using System.Collections.Generic;
using System.IO;

namespace Homework7
{
    internal class Program
    {
        static readonly string pathToPhones = @"G:\repository\VS2022\Homework7\Homework7\phones.txt"; //path to already existed file "phones.txt"
        static readonly string pathToNewPhones = @"G:\repository\VS2022\Homework7\Homework7\NewPhones.txt"; //path to created file "NewPhones.txt"
        static readonly string pathToNew = @"G:\repository\VS2022\Homework7\Homework7\New.txt"; //path to created file "New.txt with parsed strings"
        static void Main(string[] args)
        {
            //Homework7Part1
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            FileInfo phones = new FileInfo(pathToPhones);
            //chosing 9 contacts from "phones.txt"
            for (int i = 0; i < 9;)
            {
                if (phones.Exists)
                {
                    Console.Write("Write the next name : ");
                    string name = Console.ReadLine();
                    Person person = new Person(name);
                    bool nameExists = person.SetAndGetPersonName(name);
                    if (nameExists)
                    {
                        person.GetPersonPhone(person);
                        phoneBook.Add(person.PersonName, person.PhoneNumber);
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("The file does not exist with this path : {0}", pathToPhones);
                }
            }
            //Copying only phones from the "phones.txt" file to the "NewPhones.txt" file
            using (StreamWriter streamWriter = new StreamWriter(pathToNewPhones, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine(new Person().GetListOfPhones(phoneBook));
            }
            using (StreamReader streamReader = new StreamReader(pathToNewPhones, System.Text.Encoding.Default))
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }

            //Homework7Part2v1
            Console.Write("Input the name to output its phone number : ");
            string nameToInput = Console.ReadLine();
            Person newPerson = new Person();
            bool inputedNameExists = newPerson.SetAndGetPersonName(nameToInput);
            if (inputedNameExists)
            {
                newPerson.GetPersonPhone(newPerson);
            }
            else
            {
                Console.WriteLine("Inputed person does not exist in the file context!!!");
            }
            //Homework7Part2v2
            Console.Write("Input the name to output its phone number : ");
            string nameToInputV2 = Console.ReadLine();
            bool doesNotExist = false;//name does not exist
            foreach (KeyValuePair<string, string> item in phoneBook)
            {
                if (item.Key == nameToInputV2)
                {
                    Console.WriteLine("Its phone number : {0}", item.Value);
                    doesNotExist = false;
                    break;
                }
                else
                {
                    doesNotExist = true;
                }
            }
            if (doesNotExist)
            {
                Console.WriteLine("Inputed name does not exist in the file context!!!");
            }

            //Homework7Part3
            string parsedString = string.Empty;
            DirectoryInfo NewPath = new DirectoryInfo(@"G:\repository\VS2022\Homework7\Homework7\New.txt");
            using (StreamReader streamReader = new StreamReader(pathToNewPhones, System.Text.Encoding.Default))
            {
                parsedString = new Phones().PhoneNumbersToParse(streamReader);//splits all string items that they can be processed
            }
            using (StreamWriter streamWriter = new StreamWriter(pathToNew.ToString(), false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine(parsedString);
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
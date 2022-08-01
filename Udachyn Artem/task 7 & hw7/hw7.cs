using System;
using System.Collections.Generic;
using System.IO;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string text = File.ReadAllText(@"E:\New\phones.txt");
            List<string> txt = new List<string>();
            string tx = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && text[i] != '\r' && text[i] != '\n')
                {
                    tx += text[i];
                }
                else if (text[i] == ' ' || (text[i] != '\r' && text[i + 1] != '\n'))
                {
                    txt.Add(tx);
                    tx = "";
                }
                if (i == text.Length - 1)
                {
                    txt.Add(tx);
                }
            }


            for (int i = 0; i < txt.Count; i++)
            {
                int j = i + 1;
                phonebook.Add(txt[i], txt[j]);
                i++;
            }

            foreach (var item in phonebook)
            {
                Console.WriteLine(item);

            }

            using StreamWriter writer = new StreamWriter(@"E:\New\phone.txt");
            foreach (var item in phonebook)
            {
                writer.WriteLine(item.Key);

            }
        a1:
            Console.WriteLine("Write name");
            string name = Console.ReadLine();
            int ij = 0;
            try
            {
                foreach (var item in phonebook)
                {
                    ij++;
                    if (item.Value == name)
                    {
                        Console.WriteLine(item.Key);
                    }

                    else if (ij == phonebook.Count)
                    {
                        throw new Exception("Wrong name, try again");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto a1;
            }


            using StreamWriter @new = new StreamWriter(@"E:\New\New.txt");
            foreach (var item in phonebook)
            {
                if (item.Key.StartsWith("80"))
                {
                    @new.WriteLine(item.Key.Replace("80", "+380"));
                }

            }
        }
    }
}
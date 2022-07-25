using System.IO;

namespace Homework7
{
    internal class Phones
    {
        public Phones() //class added as a method container for PhoneNumbersToParse()
        {

        }

        public string PhoneNumbersToParse(StreamReader streamReader)
        {
            string toConcat = string.Empty;
            string phoneNumbers = streamReader.ReadToEnd();
            string[] splitedString = phoneNumbers.Split(',');
            string[] secondSplit;
            int counterForFinalSeparator = 0;
            foreach (string item in splitedString)
            {
                secondSplit = item.Split('\n', '\r');
                foreach (string item2 in secondSplit)
                {
                    if (item2.Length != 0 || item2 != string.Empty)
                    {
                        if (item2.StartsWith("List"))
                        {
                            toConcat += item2 + "\n";
                            counterForFinalSeparator++;
                        }
                        else if (!item2.StartsWith("+3"))
                        {
                            toConcat = string.Concat(toConcat, "+3", item2);
                            counterForFinalSeparator++;
                            if (counterForFinalSeparator <= 9)
                            {
                                toConcat = string.Concat(toConcat, ",\n");
                            }
                        }
                        else
                        {
                            toConcat = string.Concat(toConcat, item2);
                            counterForFinalSeparator++;
                            if (counterForFinalSeparator <= 9)
                            {
                                toConcat = string.Concat(toConcat, ",\n");
                            }
                        }
                    }
                }
            }
            return toConcat;
        }
    }
}

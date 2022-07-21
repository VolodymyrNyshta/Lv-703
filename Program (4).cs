using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string readPath = @"C:\Users\V\Desktop\SoftServe\test.txt";
                string writedPath = @"C:\Users\V\Desktop\SoftServe\test2.txt";
                string myText;
                string myText2= "";
                FileInfo f1 = new FileInfo(readPath);
                if (!f1.Exists) { f1.Create(); }

                FileInfo f2 = new FileInfo(writedPath);
                if (!f2.Exists) { f2.Create(); }

                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    myText = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(writedPath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(myText);
                }
                myText2 = File.ReadAllText(readPath);
                File.WriteAllText(writedPath, myText2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

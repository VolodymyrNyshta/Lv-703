using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    static class SortClass
    {
        public static void Sort(List<IDeveloper> myList)
        {
            bool flag;
            do
            {
                flag = false;
                for (int i = 0; i < myList.Count - 1; i++)
                {
                    if (myList[i].CompareTo(myList[i + 1]) > 0)
                    {
                        var tmp = myList[i];
                        myList[i] = myList[i + 1];
                        myList[i + 1] = tmp;
                        flag = true;
                    }
                }
            } while (flag);
        }
    }
}

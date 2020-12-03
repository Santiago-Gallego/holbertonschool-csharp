using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        List<int> newList = new List<int>();
        int result = 0;

        foreach (int number in myList)
        {
            if (newList.Contains(number) == false)
            {
                newList.Add(number);
            }
        }
        for (int counter = 0; counter < newList.Count; counter++)
        {
            result += newList[counter];
        }
        return result;
    }
}
using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null || myList.Count == 0){
            Console.WriteLine("List is empty");
            return -1;
        }
        int max = int.MinValue;
        foreach (int val in myList){
            if (val > max)
                max = val;
        }
        return max;
    }
}
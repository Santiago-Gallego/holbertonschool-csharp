using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i, j = 0;
        try 
        {
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                j++;
            }
        }
        catch
        {

        }
        return j;
    }
}
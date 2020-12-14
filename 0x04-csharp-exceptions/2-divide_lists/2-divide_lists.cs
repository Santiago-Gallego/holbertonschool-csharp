using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int i, result;
        List<int> newList = new List<int>();
        for (i = 0; i < listLength; i++)
        {
            try
            {
                result = list1[i]/list2[i];
                newList.Add(result);
            }
            //return newList;
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result = 0;
                newList.Add(result);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");  
            }
        }
        return newList;
    }
}
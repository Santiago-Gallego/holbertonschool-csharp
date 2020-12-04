using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        
        if (size < 0)
        {
            LinkedList<int> listEmpty = new LinkedList<int>();
            return listEmpty;
        }
        else
        {
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = i;
                Console.WriteLine(numbers[i]);
            }
            LinkedList<int> list = new LinkedList<int>(numbers);        
            return list;
        }
    }
}
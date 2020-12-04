using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i = 0;
        LinkedListNode<int> current;
        current = myLList.First;
        while (current != null)
        {
            if (i == index)
            {
                myLList.Remove(current);
                break;
            }
            i++;
            current = current.Next;
        }
    }
}
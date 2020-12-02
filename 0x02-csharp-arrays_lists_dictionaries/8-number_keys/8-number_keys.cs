using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int size = 0;
        foreach (string key in myDict.Keys){
            size++;
        }
        return size;
    }
}
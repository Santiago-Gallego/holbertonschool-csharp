using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keysList = new List<string>();

        foreach (string key in myDict.Keys){
            keysList.Add(key);
        }
        keysList.Sort();
        foreach (string key in keysList){
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}
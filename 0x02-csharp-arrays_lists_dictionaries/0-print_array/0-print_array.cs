using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0){
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] newArray = new int[size];
        for (int i = 0; i < size; i++){
            newArray[i] = i;
            if (i == size - 1)
                Console.Write(newArray[i]);
            else
                Console.Write($"{newArray[i]} ");
        }
        Console.WriteLine("");
        return newArray;
    }
}
using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int [5,5];
            array [2,2] = 1;
            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++){
                    if (j != 0)
                        Console.Write(" ");
                    Console.Write(array [i, j]);
                }
                Console.Write(" ");
            }
        }
    }
}

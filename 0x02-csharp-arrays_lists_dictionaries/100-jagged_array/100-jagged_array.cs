using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][] jagged = new int[][]
            {
                new int[] {0, 1, 2, 3},
                new int[] {0, 1, 2, 3, 4, 5, 6},
                new int[] {0, 1}
            };
            for (int i = 0; i < jagged.Length; i++) {
                for (int j = 0; j < jagged[x].Length; j++)
                    Console.Write("{0}{1}", jagged[i][j], y == (jagged[i].Length -1) ? "" : " ");
                Console.WriteLine();
            }
        }
    }
}

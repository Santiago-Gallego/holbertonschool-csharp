using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] vector = {{0, 3, 5}, {5, 5, 2}, {4, 6, 9}};
        //double[,] vector1 = {{3, 4}, {3, -2}, {4, -2}};
        double[,] vector2 = {{2, 3}, {-1, 0}};
        double[,] vector3 = {{1, 7}, {-8, -2}};
        double[,] res;
        double[,] res1;

        res = MatrixMath.Transpose(vector);
        res1 = MatrixMath.Transpose(vector2);
        
        for (int x = 0; x < res.GetLength(0); x++)
        {
            for (int y = 0; y < res.GetLength(1); y++)
            {
            Console.Write(res[x , y] + " ");
            }
            Console.WriteLine(',');
        }
        Console.WriteLine();
        for (int x = 0; x < res1.GetLength(0); x++)
        {
            for (int y = 0; y < res1.GetLength(1); y++)
            {
            Console.Write(res1[x, y] + " ");
            }
            Console.WriteLine(',');
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] vector = {{14, -3, 0}, {-11, -5, 3}, {2, -9, 13}};
        double[,] vector1 = {{6, 16, 21}, {5, 2, 0}, {1, 3, 7}};
        double[,] vector2 = {{8, -11}, {1, 2}};
        double[,] vector3 = {{-4, 9}, {1, 2}};
        double[,] res;
        double[,] res1;

        res = MatrixMath.Add(vector, vector1);
        res1 = MatrixMath.Add(vector2, vector3);
        
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
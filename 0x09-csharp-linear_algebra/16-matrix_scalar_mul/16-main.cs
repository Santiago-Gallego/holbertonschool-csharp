using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] vector = {{-13, 10, 8}, {2, 0, 14}, {-4, -5, 2}};
        //double[,] vector1 = {{6, 16, 21}, {5, 2, 0}, {1, 3, 7}};
        double[,] vector2 = {{8, -11}, {1, 2}};
        //double[,] vector3 = {{-4, 9}, {1, 2}};
        double scalar = 4;
        double[,] res;
        double[,] res1;

        res = MatrixMath.MultiplyScalar(vector, scalar);
        res1 = MatrixMath.MultiplyScalar(vector2, scalar);
        
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
using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] vector2 = {{1, 2}, {3, 4}};
        double[,] vector3 = {{-4, 9}, {1, 2}};
        double scalar = -1.57;
       // double[,] res;
       double[,] res1;

        //res = MatrixMath.Rotate2D(vector3, scalar);
        res1 = MatrixMath.Rotate2D(vector2, scalar);
        
        // for (int x = 0; x < res.GetLength(0); x++)
        // {
        //     for (int y = 0; y < res.GetLength(1); y++)
        //     {
        //     Console.Write(res[x , y] + " ");
        //     }
        //     Console.WriteLine(',');
        // }
        // Console.WriteLine();
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
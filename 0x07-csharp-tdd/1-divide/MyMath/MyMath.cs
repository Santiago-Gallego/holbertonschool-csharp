using System;

namespace MyMath
{
    /// <summary> Represents a class Matrix</summary>
    public class Matrix
    {
        /// <summary> Method that divides each item from matrix by num</summary>
        public static int[,] Divide(int[,] matrix, int num){
            if (matrix == null)
                return null;
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);
            int[,] newMatrix = new int[width,height];
            for (int x = 0; x < width; x++) 
            {
                for (int y = 0; y < height; y++) 
                {
                    int v = (matrix[x, y] / num);
                        newMatrix[x, y] = v;
                }
            }
                return newMatrix;
        }
    }
}

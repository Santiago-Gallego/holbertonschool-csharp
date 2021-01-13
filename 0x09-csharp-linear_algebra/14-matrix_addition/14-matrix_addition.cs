using System;

/// <summary>Class operations with matrices</summary>
class MatrixMath
{
    /// <summary>Method that adds two matrices</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] notPossible = {{-1}};
         if (matrix1.Length != matrix2.Length)
        {
            return notPossible;
        }
        if (matrix1.GetLength(0) < 2 || matrix2.GetLength(0) < 2 || matrix1.GetLength(0) > 3 || matrix2.GetLength(0) > 3)
        {
            return notPossible;
        }
        for (int x = 0; x < matrix1.GetLength(0); x++)
        {
            for (int y = 0; y < matrix2.GetLength(1); y++)
            {
                matrix1[x, y] = matrix1[x, y] + matrix2[x, y];
            }
        }
        return matrix1;
    }
}
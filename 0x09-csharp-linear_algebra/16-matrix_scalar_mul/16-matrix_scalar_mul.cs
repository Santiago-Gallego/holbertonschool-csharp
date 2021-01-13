using System;

/// <summary>Class operations with matrices</summary>
class MatrixMath
{
    /// <summary>Method that miltiplies a matrix and a scalar</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] notPossible = {{-1}};
        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
        {
            return notPossible;
        }
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                matrix[x, y] = matrix[x, y] * scalar;
            }
        }
        return matrix;
    }
}
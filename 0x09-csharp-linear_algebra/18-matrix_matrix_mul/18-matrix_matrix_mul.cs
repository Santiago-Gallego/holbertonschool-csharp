using System;

/// <summary>Class operations with matrices</summary>
class MatrixMath
{
    /// <summary>Method that multiplies two matrices</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] notPossible = {{-1}};
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            return notPossible;
        }

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);
        double[,] newMatrix = new double[rows1, cols2];

        for (int x = 0; x < rows1; x++)
        {
            for (int y = 0; y < cols2; y++)
            {
                double n = 0; 
                for (int z = 0; z < cols1; z++)
                {
                    //Console.WriteLine(matrix1[x,y] + "====" + matrix2[z, y]);
                    n = n + matrix1[x, z] * matrix2[z, y];
                }
                newMatrix[x, y] = n;
            }
        }
        return newMatrix;
    }
}

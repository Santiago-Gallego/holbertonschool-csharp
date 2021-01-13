using System;

/// <summary>Class operations with matrices</summary>
class MatrixMath
{
    /// <summary>Method that shear a matrix</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] newMatrix = new double[2,2];
        double[,] shearMatrix = {
            {1, factor},
            {0, 1}
        };
        double[,] notPossible = {{-1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return notPossible;
        }
        if (direction != 'x' && direction != 'y')
        {
            return notPossible;
        }
        newMatrix[0,0] = shearMatrix[0,0] * matrix[0,0] + shearMatrix[0,1] * matrix[0,1];
        //Console.WriteLine(newMatrix[0,0]);
        newMatrix[0,1] = matrix[0,1];
        //Console.WriteLine(newMatrix[0,1]);
        newMatrix[1,0] = shearMatrix[0,0] * matrix[1,0] + shearMatrix[0,1] * matrix[1,1];
        //Console.WriteLine(newMatrix[1,0]);
        newMatrix[1,1] = matrix[1,1];
        //Console.WriteLine(newMatrix[1,1]);
        return newMatrix;
    }
}
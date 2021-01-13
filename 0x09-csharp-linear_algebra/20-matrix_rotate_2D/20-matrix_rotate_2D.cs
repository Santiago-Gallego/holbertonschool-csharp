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
                    n = n + Math.Round(matrix1[x, z] * matrix2[z, y]);
                    //newMatrix[x, y] += matrix1[x, z] * matrix2[z, y];
                }
                newMatrix[x, y] = n;
            }
        }
        return newMatrix;
    }
    
    /// <summary>Method that rotates a matrix</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double angleCos = Math.Cos(angle);
        double angleSin = Math.Sin(angle);
        double[,] cosSin = {
            {angleCos, -angleSin}, 
            {angleSin, angleCos}
            // {angleSin, angleCos}, 
            // {angleCos, angleSin}
            };
        double[,] newMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
        double[,] notPossible = {{-1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return notPossible;
        }
        newMatrix = Multiply(cosSin, matrix);
        // for (int x = 0; x < matrix.GetLength(0); x++)
        // {
        //     for (int y = 0; y < 1; y++)
        //     {
        //         // Console.WriteLine(matrix[x, y] + "===" + matrix[x, y+1]);
        //         // Console.WriteLine((matrix[x, y] * angleCos) + "===" + (matrix[x, y + 1] * (angleSin)));
        //         matrix[x, y] = Math.Round((matrix[x, y] * angleCos) - (matrix[x, y + 1] * (angleSin)), 2);
        //         matrix[x, y + 1] = Math.Round((matrix[x, y] * angleSin) + (matrix[x, y + 1] * (angleCos) + 1), 2);
        //         // matrix[x, y] = (matrix[x, y] * (angleCos)) - (matrix[x, y + 1] * (angleSin));
        //         // matrix[x, y + 1] = (matrix[x, y] * (angleSin)) + (matrix[x, y + 1] * (angleCos) + 1);
        //     }
        // }
        return newMatrix;
    }
}
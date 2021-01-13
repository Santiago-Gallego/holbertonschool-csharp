using System;

/// <summary>Class operations with matrices</summary>
class VectorMath
{
    /// <summary>Method that multiplies a vector and a scalar</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] notPossible = {-1};
        if (vector.Length < 2 || vector.Length > 3)
        {
            return notPossible;
        }
        for (int x = 0; x < vector.Length; x++)
        {
            vector[x] = scalar * vector[x];
        }
        return vector;
    }
}
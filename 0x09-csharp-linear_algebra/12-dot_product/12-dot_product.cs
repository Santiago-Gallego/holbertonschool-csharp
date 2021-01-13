using System;

/// <summary>Class operations with vectors</summary>
class VectorMath
{
    /// <summary>Method to obtain the dotproduct of two vectors</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
        {
            return -1;
        }
        if (vector1.Length < 2 || vector2.Length < 2 || vector1.Length > 3 || vector2.Length > 3)
        {
            return -1;
        }
        double res = 0;
        for (int x = 0; x < vector1.Length; x++)
        {
            double mult = vector1[x] * vector2[x];
            res = res + mult; 
        }
        return res;
    }
}
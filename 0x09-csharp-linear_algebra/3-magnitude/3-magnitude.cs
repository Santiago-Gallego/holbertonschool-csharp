using System;

/// <summary>Class operations with matrices</summary>
class VectorMath
{
    /// <summary>Method to find the magnitud/lenght of a vector</summary>
    public static double Magnitude(double[] vector)
    {
        //vector = [7, -3, -9];
        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }
        double res = 0;
        double vecLen = new double();
        foreach (double x in vector)
        {
            double sqrt = Math.Pow(x, 2);
            res = res + sqrt;
        }
        vecLen = Math.Sqrt(res);
        return Math.Round(vecLen, 2); 
    }
}
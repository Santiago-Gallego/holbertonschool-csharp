using System;
class Program
{
    static void Main(string[] args)
    {
        double[] vector = {7, -3, -9};
        double[] vector1 = {3, 9};
        double res;
        double res1;
        res = VectorMath.Magnitude(vector);
        res1 = VectorMath.Magnitude(vector1);
        Console.WriteLine(res);
        Console.WriteLine(res1);
    }
}
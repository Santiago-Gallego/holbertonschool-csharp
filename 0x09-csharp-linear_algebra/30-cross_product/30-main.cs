using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector = {2, -2, 1};
        double[] vector1 = {-8, 8, -4};
        double[] res;
        
        res = VectorMath.CrossProduct(vector, vector1);
        
        foreach (double x in res)
        {
            Console.WriteLine(x);
        }
    }
}
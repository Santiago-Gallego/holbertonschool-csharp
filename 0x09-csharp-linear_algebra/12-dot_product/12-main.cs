using System;
class Program
{
    static void Main(string[] args)
    {
        double[] vector = {-4, 0, 10};
        double[] vector1 = {3, 7, -9};
        double[] vector2 = {1, 3};
        double[] vector3 = {-2, 5};
        double res;
        double res1;

        res = VectorMath.DotProduct(vector, vector1);
        res1 = VectorMath.DotProduct(vector2, vector3);
        
        Console.WriteLine(res);
        Console.WriteLine(res1);
   }
}
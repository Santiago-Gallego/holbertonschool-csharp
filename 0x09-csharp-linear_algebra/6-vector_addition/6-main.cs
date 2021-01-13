using System;
class Program
{
    static void Main(string[] args)
    {
        double[] vector = {14, -2, 0};
        double[] vector1 = {-3, 23, 50};
        double[] vector2 = {8, -11};
        double[] vector3 = {-4, 9};
        double[] res;
        double[] res1;
        res = VectorMath.Add(vector, vector1);
        res1 = VectorMath.Add(vector2, vector3);
        foreach (double x in res)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine();
        foreach (double y in res1)
        {
            Console.WriteLine(y);
        }
    }
}
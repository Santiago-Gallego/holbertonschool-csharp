using System;
class Program
{
    static void Main(string[] args)
    {
        double[] vector = {0, -16, 31};
        double[] vector2 = {98, 972};
        double scalar = 4;
        double scalar1 = 0.5;
        double[] res;
        double[] res1;
        res = VectorMath.Multiply(vector, scalar);
        res1 = VectorMath.Multiply(vector2, scalar1);
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
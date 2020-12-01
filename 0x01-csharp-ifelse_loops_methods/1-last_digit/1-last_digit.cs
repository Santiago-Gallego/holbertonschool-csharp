using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int last = number % 10;
        Console.Write("The last digit of {0} is {1}", number, last);
        if (last > 5)
            Console.Write(" and is greater than 5");
        else if (last == 0)
            Console.Write(" and is 0");
        else
            Console.Write(" and is less than 6 and not 0");
    }
}

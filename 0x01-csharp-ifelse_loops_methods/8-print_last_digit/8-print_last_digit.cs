using System;

namespace _8_print_last_digit
{
    class Number
    {
        public static int PrintLastDigit(int number)
        {
            Console.Write(Math.Abs(number % 10));
            return (Math.Abs(number % 10));
        }
    }
}

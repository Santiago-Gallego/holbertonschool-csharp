using System;

namespace _10_print_line
{
    class Line
    {
        public static void PrintLine(int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (length <= 0){
                } else {
                    Console.Write("_");
                }
            }
            Console.Write("\n");
        }
    }
}

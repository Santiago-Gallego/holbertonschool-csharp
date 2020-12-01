using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 98; i++)
            {
                int j = i;
                Console.Write("{0} = 0x{1:x} \n",i,j);
            }
        }
    }
}

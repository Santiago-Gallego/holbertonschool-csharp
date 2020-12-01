using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            string j;
            for (int i = 0; i < 100; i++)
            {
                if (i < 99){
                    j = "0";
                    if (i >= 10){
                        j = null;
                    }
                    Console.Write("{0}{1}, ",j ,i);
                } else {
                    
                    Console.Write("{0}\n",i);
                }   
            }
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
            string str = "Holberton School";
            string res = str.Split(' ')[0];;
            Console.Write("{0}{0}{0}" + "\n", str);
            Console.WriteLine(res);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text
{
    /// <summary> Represents a class Str</summary>
    public class Str
    {
        /// <summary> returns first unique character in string</summary>
        public static int UniqueChar(string s)
        {
            string s1 = "";
            string s2 = "";

            if (s == "" || s == null)
                return -1;

            int rep = 0;
            for (int i = 0; i < s.Length; i++)
            {
                s1 = s.Substring(i, 1);
                // Console.WriteLine(s1);
                // Console.WriteLine("-------");
                int indexMin = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    s2 = s.Substring(j, 1);
                    // Console.Write(s2);
                    // Console.WriteLine("--------");
                    if ((s1 == s2) && (i != j))
                        continue;

                    else if ((s1 != s2) && (i != j))
                    {
                        indexMin++;
                        if (indexMin == s.Length - 1 && rep < indexMin)
                        {
                            rep = indexMin;
                            return(i);
                        }
                    }
                }
            }
            return -1; 
        }
    }
}

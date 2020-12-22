using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text
{
    /// <summary> Represents a class Str</summary>
    public class Str
    {
        /// <summary> method that returns true if palindrome or false otherwise</summary>
        public static bool IsPalindrome(string s)
        {
            if (s == "")
            {
                return true;
            }
            var newS = new StringBuilder();
            foreach (char c in s)
            {
                if ((!char.IsPunctuation(c)) && c != ' ')
                {
                    newS.Append(c);
                }
            }
            string s2 = newS.ToString();
            s2 = s2.ToLower();
            char[] arr = s2.ToCharArray();
            Array.Reverse(arr);
            //Console.WriteLine(s2);
            //Console.WriteLine(arr);
            for (int i = 0; i < s2.Length; i++)
            {
                //Console.WriteLine(s2[i] + '-' + arr[i]);
                if (s2[i] == arr[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
            //string newS = new string(newS.Where(c => !char.IsPunctuation(c)).ToArray());
            //s = newS.ToString();
        }
    }
}

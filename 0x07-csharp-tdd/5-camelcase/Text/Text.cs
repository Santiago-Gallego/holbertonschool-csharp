using System;

namespace Text
{
    /// <summary> Represents a class Str</summary>
    public class Str
    {
        /// <summary> methos that returns the number of words un a camelcase string</summary>
        public static int CamelCase(string s)
        {
            if (s == "" || s == null)
                return 0;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    count++;
                }
            }
            return count + 1;
        }
    }
}

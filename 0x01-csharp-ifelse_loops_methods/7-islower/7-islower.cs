using System;

namespace _7_islower
{
    class Character
    {
        public static bool IsLower(char c)
        {
            if (c >= 'a' && c <= 'z'){
                return true;
            } else {
                return false;
            }
        }
    }
}

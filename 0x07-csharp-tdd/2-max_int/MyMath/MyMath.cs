using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> Represents a class operations</summary>
    public class Operations
    {
        /// <summary> returns max int within a list</summary>
        public static int Max(List<int> nums)
        {

            if (nums == null || nums.Count <= 0)
                return 0;
            int i = 1;
            int maxVal = nums[0];
            while (i < nums.Count) 
            {
                if (nums[i] > maxVal) 
                {
                    maxVal = nums[i];
                }
                i++;
            }
            return maxVal;
        }
    }
}

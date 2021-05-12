using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    public class SingleNumber
    {
        public int SingleNumbers(int[] nums)
        {
            int number = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                number ^= nums[i];
            }
            return number;
        }
    }
}

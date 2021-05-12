using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode26
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[j])
                {
                    j++;
                    nums[j] = nums[i];
                }
            }
            return j + 1;
        }
    }
}

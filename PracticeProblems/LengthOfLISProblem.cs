using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LengthOfLISProblem
    {
        public int LengthOfLIS(int[] nums)
        {
            Console.WriteLine(MaxArray(nums, 0, -1));
            return 1;
        }

        public int MaxArray(int[] nums, int i, int currentMax)
        {
            if (i==nums.Length)
            {
                return 0;
            }
            int taken = 0;
            if (nums[i] > currentMax)
            {
               taken = 1+ MaxArray(nums, i + 1, nums[i]);
            }
            int notTaken = MaxArray(nums, i+1, currentMax);
            return Math.Max(taken, notTaken);
        }
    }
}

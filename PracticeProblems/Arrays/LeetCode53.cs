using System;

namespace LeetCode.Arrays
{
    public class LeetCode53
    {
        public int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int count = 0;
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (sum < 0)
                {
                    sum = 0;
                    count = 0;
                    sum += nums[i];
                    count++;
                }
                else
                {
                    sum += nums[i];
                    count++;
                }
                max = Math.Max(max, sum);
            }
            return max;
        }
    }
}

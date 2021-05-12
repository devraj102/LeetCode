using System;

namespace LeetCode
{
    public class LeetCode213
    {

        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            if (nums.Length == 2)
            {
                return Math.Max(nums[0], nums[0 + 1]);
            }
            return Math.Max(RobHouse(nums, 0, nums.Length - 1), RobHouse(nums, 1, nums.Length));
        }
        public int RobHouse(int[] nums, int start, int end)
        {
            int[] dp = new int[end - start];
            dp[0] = nums[start];
            dp[1] = Math.Max(nums[start], nums[start + 1]);
            for (int i = start + 2, j = 2; i < end; j++, i++)
            {
                dp[j] = Math.Max(dp[j - 1], dp[j - 2] + nums[i]);
            }
            return dp[end - start - 1];
        }  
    }
}

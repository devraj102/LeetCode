using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Arrays
{
    public class TwoSum
    {
        /// <summary>
        /// Two Sum
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSums(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target == nums[i] + nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };
        }

        public int[] TwoSum1(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dict.Add(nums[i], i);
            }
            int p = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                p = target - nums[i];
                if (dict.ContainsKey(p))
                {
                    if (dict[p] != i)
                    {
                        return new int[] { dict[p], i };
                    }
                }
            }
            return new int[] { 0, 0 };
        }
    }
}

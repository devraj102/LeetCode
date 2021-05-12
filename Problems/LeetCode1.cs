using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode1
    {
        public int[] TwoSum1(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int check = target - nums[i];
                if (dict.ContainsKey(check))
                {
                    result[1] = dict[check];
                    result[0] = i;
                }
            }
            return result;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i && nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0,0 };
        }        
    }
}

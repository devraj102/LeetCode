using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode645
    {
        public int[] FindErrorNums(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();
            int[] result = new int[2];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.Contains(nums[i]))
                {
                    hash.Add(nums[i]);
                    result[0] = nums[i];

                }
                else
                {
                    hash.Add(nums[i]);
                    sum += nums[i];
                }
            }
            int n = nums.Length;
            int sumOfN = (n * (n + 1)) / 2;
            result[1] = sumOfN - sum;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class LeetCode1695
    {

        public int MaximumUniqueSubarray(int[] nums)
        {
            int max = int.MinValue;
            int i = 0, j = 0;
            HashSet<int> hash = new HashSet<int>();
            int sum = 0;
            while (i < nums.Length && j < nums.Length)
            {
                if (hash.Contains(nums[j]))
                {
                    sum -= nums[i];
                    hash.Remove(nums[i++]);
                }
                else
                {
                    sum += nums[j];
                    hash.Add(nums[j++]);
                    max = Math.Max(max, sum);
                }

            }
            return max == int.MinValue ? 0 : max;
        }

        /// <summary>
        /// n2 solution
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaximumUniqueSubarray1(int[] nums)
        {
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i;
                HashSet<int> hash = new HashSet<int>();

                for (; j < nums.Length; j++)
                {
                    if (hash.Contains(nums[j]))
                    {
                        break;
                    }
                    else
                    {
                        hash.Add(nums[j]);
                    }
                }
                int sum = 0;
                foreach (var item in hash)
                {
                    sum += item;
                }
                max = Math.Max(max, sum);
            }
            return max == int.MinValue ? 0 : max;
        }
    }
}

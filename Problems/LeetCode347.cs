using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class LeetCode347
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            
            return dict.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Key).ToArray();
        }
    }
}

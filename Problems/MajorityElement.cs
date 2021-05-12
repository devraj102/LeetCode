using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MajorityElement
    {
        public int MajorityElements(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int max = Int32.MinValue;
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
                max = Math.Max(dict[nums[i]], max);
            }
            int result = 0;
            foreach (var item in dict)
            {
                if (item.Value == max)
                {
                    result = item.Key;
                }
            }
            return result;
        }
    }
}

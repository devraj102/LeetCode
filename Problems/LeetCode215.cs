using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class LeetCode215
    {
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums.OrderByDescending(x => x).Skip(k - 1).FirstOrDefault();
        }
    }
}

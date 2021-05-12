using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FindUnsortedSubarray
    {
        public int findUnsortedSubarrayppp(int[] nums)
        {
            int min = Int32.MaxValue, max = Int32.MinValue;
            bool flag = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                    flag = true;
                if (flag)
                    min = Math.Min(min, nums[i]);
            }
            flag = false;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] > nums[i + 1])
                    flag = true;
                if (flag)
                    max = Math.Max(max, nums[i]);
            }
            int l, r;
            for (l = 0; l < nums.Length; l++)
            {
                if (min < nums[l])
                    break;
            }
            for (r = nums.Length - 1; r >= 0; r--)
            {
                if (max > nums[r])
                    break;
            }
            return r - l < 0 ? 0 : r - l + 1;
        }

    }
}

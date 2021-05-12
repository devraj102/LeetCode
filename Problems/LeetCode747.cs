using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode747
    {
        public int DominantIndex(int[] nums)
        {
            int maxValue = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxValue)
                {
                    maxValue = nums[i];
                    maxIndex = i;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (i!=maxIndex &&nums[i] * 2 > maxValue)
                {
                    return -1;
                }
            }
            return maxIndex;
        }
    }
}

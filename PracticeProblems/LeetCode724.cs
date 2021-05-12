using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode724
    {
        public int PivotIndex(int[] nums)
        {
            int i = 1;
            int j = nums.Length - 2;
            int sumL = 0;
            int sumR = 0;
            if (nums.Length == 1)
            {
                return nums[0];
            }
            sumL += nums[0];
            sumR += nums[nums.Length - 1];
            int index = -1;
            while (i <= j)
            {

                if (sumL > sumR)
                {
                    sumR += nums[j];
                    j--;
                }
                else if (sumL < sumR)
                {
                    sumL += nums[i];
                    i++;
                }
                else
                {
                    index = i;
                    break;
                }
            }
            if (sumL == sumR && i!=j)
            {
                index = i;
            }
            return index;
        }
    }
}

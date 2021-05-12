using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode75
    {
        public void SortColors(int[] nums)
        {
            int i = 0;
            int j = nums.Length - 1;
            while (i<j)
            {
                if(nums[i]>nums[j])
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] left2right = new int[nums.Length + 1];
            int[] right2left = new int[nums.Length + 1];
            left2right[0] = 1;
            right2left[right2left.Length - 1] = 1;
            int j = nums.Length-1;
            for (int i = 1; i <= nums.Length; i++)
            {
                left2right[i] = nums[i-1] * left2right[i - 1];
                right2left[j] = nums[j] * right2left[j + 1];
                j--;
            }
            for (int i = 1; i <= nums.Length; i++)
            {
                nums[i-1] = left2right[i-1] * right2left[i];
            }
            return nums;
        }
    }
}

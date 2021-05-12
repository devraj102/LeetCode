using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode152
    {
        public int MaxProduct(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int max = int.MinValue;
            int product = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                product *= nums[i];
                max = Math.Max(product, max);
                product = product == 0 ? 1 : product;
            }
            product = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                product *= nums[i];
                max = Math.Max(product, max);
                product = product == 0 ? 1 : product;
            }
            return max;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode560
    {
        public int SubarraySum(int[] nums, int k)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (subset(nums, k, 0, i))
                {
                    count++;
                }
            }
            return count;
        }
        public bool subset(int[] nums, int k, int sum, int i)
        {
            if (nums.Length == 0 || i < 0 || i > nums.Length-1)
            {
                return false;
            }
            sum += nums[i];
            if (sum == k)
            {
                return true;
            }

            return subset(nums, k, sum, i+1);
        }
            public int SubarraySum1(int[] nums, int k)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
           
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == k)
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
    }
}

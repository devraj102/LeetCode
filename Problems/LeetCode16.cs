using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode16
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int result = 0;
            int lastMin = Int32.MaxValue;
            int min = Int32.MaxValue;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i + 1;
                int p = nums.Length - 1;
                while (j < p)
                {
                    int sum = nums[i] + nums[j] + nums[p];
                    min = Math.Min(Math.Abs(target - sum), min);
                    if (min != lastMin)
                    {
                        result = sum;
                    }
                    lastMin = min;
                    if (sum == target)
                    {
                        j++;
                        p--;
                    }
                    else if (sum > target)
                    {
                        p--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class FindTargetSumWaysProblem
    {
        int count = 0;
        public int FindTargetSumWays(int[] nums, int S)
        {
            FindWays(nums, S, 0, 0);
            return count;
        }
        public void FindWays(int[] nums, int S, int i, int sum)
        {
            if (S == sum && i == nums.Length)
            {
                count++;
                return;
            }
            if (nums.Length == 0 || i > nums.Length - 1 || i < 0)
            {
                return;
            }
            else
            {
                FindWays(nums, S, i + 1, sum + nums[i]);
                FindWays(nums, S, i + 1, sum - nums[i]);
            }
        }
    }

    public class FindTargetSumWaysProblem1
    {
        int count = 0;
        public int FindTargetSumWays(int[] nums, int S)
        {
            FindWays(nums, S, 0, 0);
            return count;
        }
        public void FindWays(int[] nums, int S, int i, int sum)
        {
            if (nums.Length == i)
            {
                if (S == sum)
                {
                    count++;
                    return;
                }
            }
            else
            {
                FindWays(nums, S, i + 1, sum + nums[i]);
                FindWays(nums, S, i + 1, sum - nums[i]);
            }
        }
    }
}
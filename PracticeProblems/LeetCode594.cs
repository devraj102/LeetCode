using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class LeetCode594
    {
        public int FindLHS(int[] nums)
        {
            List<int> list = new List<int>();
            if (nums.Length == 1)
            {
                return 0;
            }
            //int max = Math.Max(nums[0], nums[1]);
            int maxElement = Math.Max(nums[0], nums[1]);
            int max =0;
            for (int i = 1; i < nums.Length; i++)
            {
                int count = 0;
                maxElement = Math.Max(nums[i], nums[i - 1]);
                for (int j = 0; j < nums.Length; j++)
                {
                    if (maxElement - nums[j] == 1 || maxElement - nums[j] == 0)
                    {
                        list.Add(nums[j]);
                        count++;
                    }
                }
                list.Sort();
                if (Math.Abs(list[0] - list[list.Count - 1]) != 1)
                {
                    count = 0;
                }
                list.Clear();
                max = Math.Max(count, max);
            }
            return max;
        }
        List<int> list;
        public int FindLHS1(int[] nums)
        {
            list = new List<int>();
            FindArray(nums, 0, nums[0]);
            return list.Count;
        }
        private void FindArray(int[] nums, int i, int max)
        {
            if (i < 0 || i > nums.Length-1)
            {
                return;
            }
            if (Math.Abs(nums[i] - max) == 0 || Math.Abs(nums[i] - max) == 1)
            {
                list.Add(nums[i]);
                FindArray(nums, i + 1, max);
            }
            else
            {
                FindArray(nums, i + 1, max);
            }
        }
    }
}

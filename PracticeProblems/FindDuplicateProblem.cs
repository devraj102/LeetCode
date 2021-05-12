using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FindDuplicateProblem
    {
        public int FindDuplicate(int[] nums)
        {
            int[] array = new int[nums.Length + 1];
            int duplicate = 0;
            int missing = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (array[nums[i]] > 0)
                {
                    duplicate = nums[i];
                }
                array[nums[i]] = nums[i];
            }
            //for (int i = 1; i <= nums.Length; i++)
            //{
            //    if (array[i] == 0)
            //    {
            //        missing = i;
            //    }
            //}
            //list.Add(missing);
            return duplicate;
        }

        public int FindDuplicate1(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    return nums[i];
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            return -1;
        }
    }
}

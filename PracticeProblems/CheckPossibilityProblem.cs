using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class CheckPossibilityProblem
    {
        public bool CheckPossibility(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    int temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;
                    break;
                }
            }
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    count++;
                }
            }
            return count == 0 ? true : false;
        }
    }
}

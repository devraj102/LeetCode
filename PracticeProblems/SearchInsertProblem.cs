using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SearchInsertProblem
    {
        // linear solution
        public int SearchInsert1(int[] nums, int target)
        {
            if (target > nums[nums.Length - 1])
            {
                return nums.Length;
            }
            int j = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
                else if (nums[i] > target && target < nums[i + 1])
                {
                    return j;
                }
                j++;
            }

            return j;
        }
        // binary search
        public int SearchInsert(int[] nums, int target)
        {
            if (target > nums[nums.Length - 1])
            {
                return nums.Length;
            }
            int low = 0;
            int high = nums.Length - 1;
            int mid = 0;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }
    }
}

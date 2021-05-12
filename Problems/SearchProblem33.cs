using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SearchProblem33
    {
        public int Search(int[] nums, int target)
        {
            int high = nums.Length - 1;
            int low = 0;
            int mid = 0;
            while (low < high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > nums[mid + 1])
                {
                    break;
                }
                else if (nums[low] > nums[mid])
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            //-----Search in Left array
            int h = mid;
            int l = 0;
            int m;
            while (l <= h)
            {
                m = l + (h - l) / 2;
                if (nums[m] == target)
                {
                    return m;
                }
                else if (nums[m] < target)
                {
                    l = m + 1;
                }
                else
                {
                    h = m - 1;
                }
            }
            // -- if not found  //-----Search in right array
            h = nums.Length - 1;
            l = mid + 1;
            while (l <= h)
            {
                m = l + (h - l) / 2;
                if (nums[m] == target)
                {
                    return m;
                }
                else if (nums[m] < target)
                {
                    l = m + 1;
                }
                else
                {
                    h = m - 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// Understand this solution
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int UnderstandSearch(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] == target) return mid;
                if (nums[low] <= nums[mid]) // 3 4 5 6 0 1 2
                {
                    if (target >= nums[low] && target <= nums[mid])
                        high = mid;
                    else
                        low = mid + 1;
                }
                else // 5 6 0 1 2 3 4
                {
                    if (target >= nums[mid] && target <= nums[high])
                        low = mid;
                    else
                        high = mid - 1;
                }
            }
            return -1;
        }

    }
}

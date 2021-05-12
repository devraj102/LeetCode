using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RemoveDuplicates
    {
        public int removeDuplicatesa(int[] A)
        {
            if (A.Length < 2)
            {
                return A.Length;
            }
            int id = 1;
            for (int i = 1; i < A.Length; ++i)
            {
                if (A[i] != A[i - 1])
                {
                    A[id++] = A[i];
                }
            }
            return id;
        }
        public int RemoveDuplicatess(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    nums[i-1] = 1000000;
                }
            }
            int count = 0;
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 1000000)
                {
                    nums[j] = nums[i];
                    j++;
                    count++;
                }
            }

            for (; j < nums.Length; j++)
            {
                nums[j] = 1000000;
            }
            return count;
        }
    }
}

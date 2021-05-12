using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class FindDisappearedNumbers
    {

        public IList<int> FindDisappearedNumbers1(int[] nums)
        {
            //4,3,2,7,8,2,3,1
            //1,2,2,3,3,4,7,8
            IList<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int mm = Math.Abs(nums[i]);
                nums[mm - 1] = nums[mm - 1] > 0 ? nums[mm - 1] * -1 : nums[mm - 1];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    list.Add(i + 1);
                }
            }
            return list;
        }
        public IList<int> FindDisappearedNumberss(int[] nums)
        {
            IList<int> list = new List<int>();
            int[] arr = new int[nums.Length + 1];
            foreach (var item in nums)
            {
                arr[item] = 1;
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}

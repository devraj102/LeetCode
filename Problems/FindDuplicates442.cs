using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FindDuplicates442
    {
        public IList<int> FindDuplicates1(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            IList<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    list.Add(nums[i]);
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }

            return list;
        }
        public IList<int> findDuplicates(int[] nums)
        {
            IList<int> res = new List<int>();
            for (int i = 0; i < nums.Length; ++i)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] < 0)
                    res.Add(Math.Abs(index + 1));
                nums[index] = -nums[index];
            }
            return res;
        }
    }
}

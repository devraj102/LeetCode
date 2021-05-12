using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class LeetCode46
    {
        IList<List<int>> listOfList;
        public IList<IList<int>> Permute(int[] nums)
        {
            listOfList = new List<List<int>>();
            if (nums.Length == 0)
            {
                return listOfList.Cast<IList<int>>().ToList();
            }
            AllPermutation(nums, nums.Length, nums.Length);
            return listOfList.Cast<IList<int>>().ToList();
        }
        public void AllPermutation(int[] num, int l, int r)
        {
            if (r == 1)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < num.Length; i++)
                {
                    list.Add(num[i]);

                }
                listOfList.Add(list);
            }
            else
            {
                for (int i = 0; i < r; i++)
                {
                    AllPermutation(num, l, r - 1);
                    // if size is odd, swap 0th i.e (first) and
                    // (size-1)th i.e (last) element
                    if (r % 2 == 1)
                    {
                        int temp = num[0];
                        num[0] = num[r - 1];
                        num[r - 1] = temp;
                    }

                    // If size is even, swap ith and
                    // (size-1)th i.e (last) element
                    else
                    {
                        int temp = num[i];
                        num[i] = num[r - 1];
                        num[r - 1] = temp;
                    }
                }
            }
        }

    }
}

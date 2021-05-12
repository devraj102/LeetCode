using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class LeetCode78
    {
        IList<List<int>> listOfList;
        public IList<IList<int>> Subsets(int[] nums)
        {
            listOfList = new List<List<int>>();
            if (nums.Length == 0)
            {
                return listOfList.Cast<IList<int>>().ToList();
            }
            else
            {
                listOfList.Add(new List<int>());
                int n = Convert.ToInt32(Math.Pow(2, nums.Length)) - 1;
                while (n != 0)
                {
                    string ss = Convert.ToString(n, 2);
                    ss = ss.PadLeft(nums.Length, '0');
                    List<int> list = new List<int>();
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (ss[i] == '1')
                        {
                            list.Add(nums[i]);
                        }
                    }
                    listOfList.Add(list);
                    n--;
                }
            }
            return listOfList.Cast<IList<int>>().ToList();
        }

        public IList<IList<int>> Subsets2(int[] nums)
        {
            listOfList = new List<List<int>>();
            if (nums.Length == 0)
            {
                return listOfList.Cast<IList<int>>().ToList();
            }
            else
            {
                PowerSetOfArray(nums, 0, new List<int>());
            }
            return listOfList.Cast<IList<int>>().ToList();
        }
        public void PowerSetOfArray(int[] input, int i, List<int> set)
        {
            if (i == input.Length)
            {
                listOfList.Add(set);
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------");
                return;
            }
            PowerSetOfArray(input, i + 1, new List<int>(input[i]));
            //set.Add(input[i]);
            PowerSetOfArray(input, i + 1, set);
        }

    }
}

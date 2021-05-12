using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SortColors
    {
        /// <summary>
        /// method 1
        /// </summary>
        /// <param name="nums"></param>
        public void SortColor1(int[] nums)
        {
            Array.Sort(nums);

        }

        public void SortColor(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, 0);
            dict.Add(1, 0);
            dict.Add(2, 0);           
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 2)
                {
                    dict[2]++;
                }
                else if (nums[i] == 1)
                {
                    dict[1]++;
                }
                else
                {
                    dict[0]++;
                }
            }
            int k = 0;
            foreach (var item in dict)
            {
                for (int p = 0;  p < item.Value; p++)
                {
                    nums[k] = item.Key;
                    k++;
                }
            }
        }
    }
}

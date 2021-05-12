using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode575
    {
        public int DistributeCandies(int[] candyType)
        {
            int n = candyType.Length / 2;
            int count = 0;
            HashSet<int> dict = new HashSet<int>();
            for (int i = 0; i < candyType.Length; i++)
            {
                if (!dict.Contains(candyType[1]))
                {
                    dict.Add(candyType[i]);
                    n--;
                    count++;
                }
                if (n == 0)
                {
                    break;
                }
            }
            return count;
        }
    }
}

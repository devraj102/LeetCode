using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.StringAlgo
{
    class LeetCode3
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max = int.MinValue;
            for (int i = 0; i < s.Length; i++)
            {
                int j = 0;
                int[] chr = new int[27];

                for (; j < s.Length; j++)
                {
                    if (chr[s[j] - 'a'] == 1)
                    {
                        break;
                    }
                    else
                    {
                        chr[s[j] - 'a'] = 1;
                    }
                }
                int count = 0;
                foreach (var item in chr)
                {
                    if (item == 1)
                    {
                        count++;
                    }
                }
                max = Math.Max(max, count);

            }
            return max == int.MinValue ? 0 : max;
        }
    }
}

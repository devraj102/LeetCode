using System;

namespace LeetCode
{
    public class LeetCode3
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max = int.MinValue;
            for (int i = 0; i < s.Length; i++)
            {
                int j = i;
                int[] chr = new int[128];

                for (; j < s.Length; j++)
                {
                    if (chr[(int)s[j]] == 1)
                    {
                        break;
                    }
                    else
                    {
                        chr[(int)s[j]] = 1;
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

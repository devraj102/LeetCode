using System;

namespace LeetCode
{
    public class LeetCode821
    {
        public int[] ShortestToChar(string s, char c)
        {
            int[] result = new int[s.Length];
            int step = 0;
            bool isFound = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == c)
                {
                    step = 0;
                }
                else
                {
                    step++;
                }
                result[i] = step;
            }
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == c)
                {
                    step = 0;
                    isFound = true;
                }
                else if (isFound)
                {
                    step++;
                }
                else
                {
                    step = int.MaxValue;
                }

                result[i] = Math.Min(step, result[i]);
            }
            return result;
        }
    }
}

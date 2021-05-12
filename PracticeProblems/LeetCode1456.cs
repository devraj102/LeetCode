using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode1456
    {
        public int MaxVowels(string s, int k)
        {
            int max = int.MinValue;
            int vowelCount = 0;
            int[] array = new int[s.Length + 1];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    vowelCount++;
                }
                array[i + 1] = vowelCount;
            }
            double num = Convert.ToDouble(s.Length) / Convert.ToDouble(k);
            int.TryParse(Math.Ceiling(num).ToString(), out int m);
            for (int i = k; i < array.Length; i++)
            {
                max = Math.Max(array[i] - array[i - k], max);

            }
            return max;
        }
    }
}

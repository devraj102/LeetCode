using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class LeetCode1347
    {
        /// <summary>
        /// optimized solution with constant space
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public int MinSteps(string s, string t)
        {
            int[] arr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                arr[s[i] - 'a']++;
                arr[t[i] - 'a']--;
            }
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]>0)
                {
                    count += arr[i];
                }
            }
            return count;
        }
        /// <summary>
        /// solution wih 2n and O(n) space complexity
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public int MinSteps1(string s, string t)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]]++;
                }
                else
                {
                    dict.Add(s[i], 1);
                }
            }

            int count = 0;
            foreach (var item in t)
            {
                if(dict.ContainsKey(item) && dict[item]>0)
                {
                    dict[item]--;
                }
                else
                {
                    count++;
                }
            }
            return count;
        }
    }
}

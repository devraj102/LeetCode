using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class LeetCode316
    {
        public string RemoveDuplicateLetters(string s)
        {
            if (s.Length < 2)
            {
                return s;
            }
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
            StringBuilder sb = new StringBuilder();
            foreach (var item in dict)
            {
                sb.Append(item.Key);
            }
            return string.Join("", sb.ToString().ToCharArray().OrderByDescending(x => x));
        }
    }
}

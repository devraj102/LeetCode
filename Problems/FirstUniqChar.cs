using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FirstUniqChar
    {
        public int FirstUniqChars(string s)
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
            char letter = '-';
            foreach (var item in dict)
            {
                if (item.Value == 1)
                {
                    letter = item.Key;
                    break;
                }
            }
            int index = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == letter)
                {
                    index = i;
                }
            }
            return index;
        }
    }
}

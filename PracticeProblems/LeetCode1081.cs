using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode1081
    {
        public string SmallestSubsequence(string s)
        {
            bool[] arr = new bool[26];
            char[] ss = new char[26];
            for (int i = 0; i < s.Length; i++)
            {
                if (arr[s[i] - 'a'])
                {

                }
                else
                {
                    ss[s[i] - 'a'] = s[i];
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i] != '\0')
                {
                    sb.Append(ss[i]);
                }
            }
            return sb.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode139
    {

        public bool WordBreakBruteForce(string s, IList<string> wordDict)
        {
            bool result = false;
            foreach (var item in wordDict)
            {
                string ss = string.Empty;
                foreach (var word in wordDict)
                {
                    ss += word;
                    if (ss == s)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
        public bool WordBreak(string s, IList<string> wordDict)
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

            bool result = true;
            foreach (var item in wordDict)
            {
                Dictionary<char, int> temp = new Dictionary<char, int>(dict);
                for (int i = 0; i < item.Length; i++)
                {
                    if(temp.ContainsKey(item[i]) && temp[item[i]]>0)
                    {
                        temp[item[i]]--;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }

            return result;
        }
    }
}

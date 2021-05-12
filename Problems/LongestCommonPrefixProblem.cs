using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LongestCommonPrefixProblem
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return  string.Empty;
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            string prefix = string.Empty;
            for (int i = 0; i < strs[0].Length; i++)
            {

                for (int j = 1; j <strs.Length; j++)
                {
                    if (i <= strs[j].Length-1)
                    {
                        
                        if (strs[j][i] != strs[0][i])
                        {
                            return prefix;
                        }                        
                    }
                    else
                    {
                        return prefix;
                    }
                }
                prefix += strs[0][i];
            }
            return prefix;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class IsSubsequenceProblem
    {
        public bool IsSubsequence(string s, string t)
        {
            var charArr = t.ToCharArray();
            var source = s.ToCharArray();
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = index; j < charArr.Length; j++)
                {
                    if (s[i] == charArr[j])
                    {
                        charArr[j] = '*';
                        source[i] = '#';
                        index = j;
                        break;
                    }
                }
            }
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != '#')
                {
                    return false;
                }
            }
            return true;
        }

        int index = 0;
        public bool IsSubsequence1(string s, string t)
        {
            int index = 0; int j = 0;
            while (j < t.Length)
            {
                if (s[index] == t[j])
                {
                    index++;
                    if (index == s.Length)
                    {
                        return true;
                    }
                }                
                j++;
            }
            return false;
        }
        public bool func(char[] searchArray, char sourceArray, int index)
        {

            if (index < searchArray.Length && searchArray[index] == sourceArray)
            {
                return true;
            }

            func(searchArray, sourceArray, index + 1);
            return false;
        }
    }
}

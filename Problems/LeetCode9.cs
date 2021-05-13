using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode
{
    public class LeetCode9
    {
        public bool IsPalindrome(int x)
        {
            string num = x.ToString();
            int i = 0;
            int j = num.Length - 1;
            while (i <= j)
            {
                if (num[i] != num[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
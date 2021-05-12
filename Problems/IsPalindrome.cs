using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class IsPalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int reverseNumber = 0;
            int p = x;
            while (x != 0)
            {
                reverseNumber = reverseNumber * 10 + x % 10;
                x = x / 10;
            }

            return p == reverseNumber ? true : false;
        }

        public bool IsPalindrome1(int x)
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

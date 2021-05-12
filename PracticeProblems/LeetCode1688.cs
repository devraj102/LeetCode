using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode1688
    {
        public int NumberOfMatches(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            int match = 0;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    match += n / 2;
                    n /= 2;
                }
                else
                {
                    match += n / 2;
                    n = n / 2 + 1;
                }
            }
            return match;
        }
    }
}

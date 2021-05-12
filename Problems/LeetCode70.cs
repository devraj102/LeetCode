using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode70
    {
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 2; i < n; i++)
            {
                dp[i + 1] = dp[i] + dp[i - 1];
            }
            return dp[n];
        }
    }
}

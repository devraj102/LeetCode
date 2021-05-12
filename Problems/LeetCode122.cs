using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode122
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }
            if (prices.Length == 2)
            {
                return prices[1] - prices[0] > 0 ? prices[1] - prices[0] : 0;
            }
            int[] dp = new int[prices.Length + 1];
            dp[0] = 0;
            dp[1] = Math.Max(prices[1] - prices[0], dp[0]);
            for (int i = 2; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    dp[i] = dp[i - 1] + Math.Max((prices[i] - prices[i - 1]), dp[i - 1]);
                }
                else
                {
                    dp[i] = dp[i - 1];
                }
            }
            return dp[prices.Length];
        }
    }
}

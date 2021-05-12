using System;

namespace LeetCode
{
    public class LeetCode121
    {
        /// <summary>
        /// MaxProfit DP Approach
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
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
            dp[0] = prices[0];
            dp[1] = Math.Min(prices[1], prices[0]);
            int maxProfit = 0;
            for (int i = 2; i < prices.Length; i++)
            {
                dp[i] = Math.Min(prices[i], dp[i - 1]);
                maxProfit = Math.Max(prices[i] - dp[i], maxProfit);
            }
            return maxProfit;
        }
        /// <summary>
        /// O(N) Approach
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfitN(int[] prices)
        {
            int maxProfit = Int32.MinValue;
            int buy = Int32.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                {
                    buy = prices[i];
                }
                else if (prices[i] - buy > maxProfit)
                {
                    maxProfit = prices[i] - buy;
                }
            }
            return maxProfit <= 0 ? 0 : maxProfit;
        }

        /// <summary>
        /// Brute Force Approach
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfitN2(int[] prices)
        {
            int maxProfit = Int32.MinValue;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i; j < prices.Length; j++)
                {
                    maxProfit = Math.Max(maxProfit, prices[j] - prices[i]);
                }
            }
            return maxProfit <= 0 ? 0 : maxProfit;
        }
    }
}

using System;

namespace LeetCode
{
    public class LeetCode746
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            if(cost.Length==0)
            {
                return 0;
            }
            if(cost.Length ==1)
            {
                return cost[0];
            }
            int[] DP = new int[cost.Length];
            DP[0] = cost[0];
            DP[1] = cost[1];
            for (int i = 2; i < cost.Length; i++)
            {
                DP[i] = Math.Min(DP[i - 1] + cost[i], DP[i - 2] + cost[i]);
            }
            return Math.Min(DP[cost.Length - 1], DP[cost.Length - 2]);
        }
    }
}

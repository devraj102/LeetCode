using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode62
    {
        int[,] dp;
        public int UniquePaths(int m, int n)
        {
            dp = new int[m, n];

            TraverseGrid(m, n, m - 1, n - 1);
            return dp[m, n];
        }

        public int TraverseGrid(int m, int n, int i, int j)
        {
            if (i == 0 && j == 0)
            {
                return 1;
            }
            else if (i < 0 || i > m || j < 0 || j > n)
            {
                return 0;
            }
            else if (dp[i, j] != 0)
            {
                return dp[i, j];
            }
            else
            {
                dp[i, j] = TraverseGrid(m, n, i - 1, j) + TraverseGrid(m, n, i, j - 1);
            }
            return dp[i, j];
        }
        /// <summary>
        /// based on recursion
        /// </summary>
        public int UniquePaths1(int m, int n)
        {
            TraverseGrid1(m, n, 1, 1);
            return TraverseGrid1(m, n, 1, 1);
        }

        public int TraverseGrid1(int m, int n, int i, int j)
        {
            if (m == i && n == j)
            {
                return 1;
            }
            if (i < 0 || i > m || j < 0 || j > n)
            {
                return 0;
            }
            return TraverseGrid1(m, n, i + 1, j) + TraverseGrid1(m, n, i, j + 1);
        }
    }
}

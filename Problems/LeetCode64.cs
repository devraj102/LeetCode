using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class LeetCode64
    {
        List<int> list;
        int[][] dp;
        public int MinPathSum(int[][] grid)
        {
            
            list = new List<int>();
            int row = grid.Length;
            int col = grid[0].Length;
            dp = new int[row+1][];
            for (int i = 0; i <= row; i++)
            {
                dp[i] = new int[i];
            }
            TraverseGrid(grid, row - 1, col - 1, 0);
            return list.OrderBy(x => x).FirstOrDefault() + grid[0][0];
        }
        public void TraverseGrid(int[][] grid, int i, int j, int sum)
        {
            if (i == 0 && j == 0)
            {
                list.Add(sum);
                Console.WriteLine(sum);
                return;
            }
            if (i < 0 || i > grid.Length - 1 || j < 0 || j > grid[i].Length - 1)
            {
                return;
            }
            if (dp[i][j] != 0)
            {
                dp[i + 1][j + 1] = dp[i][j] + grid[i][j];
                sum = dp[i][j] + grid[i][j];
            }
            else
            {
                TraverseGrid(grid, i, j - 1, sum + grid[i][j]);
                TraverseGrid(grid, i - 1, j, sum + grid[i][j]);
            }
        }
    }
}

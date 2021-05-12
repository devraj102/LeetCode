using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class NumIslandsProblem
    {
        public int NumIslands(char[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (VisitIsland(grid, i, j))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private bool VisitIsland(char[][] grid, int i, int j)
        {
            if (grid.Length == 0 || i < 0 || j < 0 || i > grid.Length - 1 || j > grid[i].Length - 1 || grid[i][j] == '0')
            {
                return false;
            }
            grid[i][j] = '0';
            VisitIsland(grid, i + 1, j);
            VisitIsland(grid, i - 1, j);
            VisitIsland(grid, i, j + 1);
            VisitIsland(grid, i, j - 1);
            return true;
        }
    }
}

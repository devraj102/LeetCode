using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode1091
    {
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            if (grid[0][0] == 1)
            {
                return -1;
            }
            int n = grid.Length;
            int m = grid[0].Length;
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(new[] { 0, 0, 1 });
            grid[0][0] = 1;
            int[][] direction = new int[][] { new int[] { 1, 0 },new int[]{-1,0 },new int[]{0,1 }, new int[] {0,-1 },
            new int[] {-1,-1 }, new int[]{ 1,1} , new int[]{-1,1 }, new int[]{1,-1 } };
            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var point = queue.Dequeue();
                    if (point[0] == n - 1 && point[1] == m - 1)
                    {
                        return point[2];
                    }
                    foreach (var dir in direction)
                    {
                        int r = dir[0] + point[0];
                        int c = dir[1] + point[1];
                        int step = point[2];
                        if (r < 0 || r >= grid.Length || c < 0 || c >= grid[r].Length || grid[r][c] == 1)
                        {
                        }
                        else
                        {
                            queue.Enqueue(new int[] { r, c, step + 1 });
                            Console.WriteLine($"{r}, {c}");
                            grid[r][c] = 1;
                        }
                    }
                }
            }
            return -1;
        }
    }
}

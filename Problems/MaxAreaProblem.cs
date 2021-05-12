using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MaxAreaProblem
    {
        public int MaxArea(int[] height)
        {
            int i = 0;
            int j = height.Length - 1;
            int max = -1;
            while (i < j)
            {
                if (height[i] > height[j])
                {
                    max = Math.Max(height[j] * (j - i), max);
                    j--;
                }
                else
                {
                    max = Math.Max(height[i] * (j - i), max);
                    i++;
                }
            }
            return max;
        }
        // N square solution
        public int MaxArea1(int[] height)
        {
            int max = -1;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = height.Length - 1; j > i; j--)
                {
                    if (height[i] > height[j])
                    {
                        max = Math.Max(height[j] * (j - i), max);
                    }
                    else
                    {
                        max = Math.Max(height[i] * (j - i), max);
                    }
                }
            }
            return max;
        }
    }
}

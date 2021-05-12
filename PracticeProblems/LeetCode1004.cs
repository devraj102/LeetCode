using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode1004
    {
        public int LongestOnes(int[] A, int K)
        {
            int i = 0, j;
            for (j = 0; j < A.Length; ++j)
            {
                if (A[j] == 0) K--;
                if (K < 0 && A[i++] == 0) K++;
            }
            return j - i;
        }
        public int LongestOnes1(int[] A, int K)
        {
            int j = 0;
            int max = int.MinValue;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i]==0)
                {
                    K--;
                }
                while (j<=i && K<0)
                {
                    if(A[j]==0)
                    {
                        K++;
                    }
                    j++;
                }
                max = Math.Max(i - j + 1, max);
            }
            return max;
        }
    }
}

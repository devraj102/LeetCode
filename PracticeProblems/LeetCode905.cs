using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode905
    {
        public int[] SortArrayByParity(int[] A)
        {
            int[] result = new int[A.Length];
            int i = 0;
            int j = A.Length - 1;
            for (int p = 0; p < A.Length; p++)
            {
                if (A[p] % 2 == 0)
                {
                    result[i] = A[p];
                    i++;
                }
                else
                {
                    result[j] = A[p];
                    j--;
                }
            }
            return result;
        }
    }
}

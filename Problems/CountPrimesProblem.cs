using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class CountPrimesProblem
    {
        public int CountPrimes(int n)
        {
            if (n < 2)
            {
                return 0;
            }
            int[] pp = new int[n];
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (pp[i] == 0)
                {
                    for (int j = 2 * i; j < n; j = j + i)
                    {
                        pp[j] = 1;
                    }
                }
            }
            int count = 0;
            for (int i = 2; i < pp.Length; i++)
            {
                if(pp[i]==0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

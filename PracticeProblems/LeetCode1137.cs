using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode1137
    {
        public int Tribonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;
            int a = 0;
            int b = 1;
            int c = 1;
            int d;
            while (n > 2)
            {
                n--;
                d = a + b + c;
                a = b;
                b = c;
                c = d;
            }
            return c;
        }
        public int Tribonacci1(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;
            int[] DP = new int[n + 1];
            DP[0] = 0;
            DP[1] = 1;
            DP[2] = 1;
            for (int i = 3; i <= n; i++)
            {
                DP[i] = DP[i - 1] + DP[i - 2] + DP[i - 3];
            }
            return DP[n];
        }
    }
}

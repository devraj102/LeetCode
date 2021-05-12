using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode279
    {
        int count = 0;
        public int NumSquares(int n)
        {
            int c = Convert.ToInt32(Math.Floor(Math.Sqrt(n)));
            if (c * c == n)
            {
                return 1;
            }
            int min = Int32.MaxValue;
            for (int i = 2; i <= c; i++)
            {
                if (n % (i * i) == 0)
                {
                    min = Math.Min(min, n / (i * i));
                }
            }
            while (n != 0 || c >= 1)
            {
                if (c > 0)
                {
                    if (n >= c * c)
                    {
                        n = n - (c * c);
                        count++;
                    }
                }
                if (c == 0)
                {
                    count = count + n;
                    n = 0;
                }
                else
                {
                    c = c - 1;
                }
            }

            return Math.Min(min, count);
        }
        public void PerfectSquare(int n, int sum)
        {
            if (n == 0 || sum == 0)
            {
                return;
            }
            if (sum >= n * n)
            {
                count++;
                PerfectSquare(n - 1, sum - (n * n));
            }
            else
            {
                PerfectSquare(n - 1, sum);
            }
            return;
        }
    }
}

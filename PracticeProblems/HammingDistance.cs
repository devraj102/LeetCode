using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class HammingDistanceProblem
    {

        public int HammingDistance(int x, int y)
        {
            int number = x ^ y;
            return countSetBits(number);
        }
        private int countSetBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
        public int HammingDistance1(int x, int y)
        {

            int number = x ^ y;
            string num = Convert.ToString(number, 2);
            int count = 0;
            foreach (char c in num)
            {
                if (c == '1')
                {
                    count++;
                }
            }
            return count;

        }
    }
}

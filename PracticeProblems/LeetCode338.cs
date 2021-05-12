using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode338
    {
        public int[] CountBits(int num)
        {
            int[] arr = new int[num + 1];
            for (int i = 0; i <= num; i++)
            {
                arr[i] = HammingWeight(i);
            }
            return arr;
        }

        public int HammingWeight(int n)
        {
            int count = 0;
            while (n != 0)
            {
                if ((n & 1) == 1)
                {
                    count++;
                }
                n = n >> 1;
            }
            return count;
        }
    }
}

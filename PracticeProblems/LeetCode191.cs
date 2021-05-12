using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode191
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n!=0)
            {
                if((n&1)==1)
                {
                    count++;
                }
                n = n >> 1;
            }
            return count;
        }
    }
}

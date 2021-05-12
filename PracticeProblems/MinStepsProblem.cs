using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MinStepsProblem
    {
        public int MinSteps(int n)
        {
            return MinStepC(n, 1, 0);
        }

        public int MinStepC(int n, int count, int copyPaste)
        {
            if (count > n)
            {
                return 0;
            }
            if (count == n)
            {
                return 1;
            }

            return Math.Min(MinStepC(n, 2*count, 2 * count), MinStepC(n, count + copyPaste, copyPaste));

            
        }
    }
}

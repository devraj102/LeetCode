using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.StringAlgo
{
    public class NaivePatternSearching
    {
        public bool NaiveApproach(string source, string pattern)
        {
            // adqacadad ada
            int n = source.Length;
            int m = pattern.Length;
            for (int i = 0; i < source.Length; i++)
            {
                int j = 0;
                for (; j < pattern.Length; j++)
                {
                    if(source[i+j] != pattern[j])
                    {
                        break;
                    }
                }
                if(j==m)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
    
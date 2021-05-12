using System.Collections.Generic;

namespace LeetCode
{
    public class LeetCode647
    {
        public int CountSubstrings(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (ValidAnagram(s, i, j))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public bool ValidAnagram(string s, int i, int j)
        {
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}

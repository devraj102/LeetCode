using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode1641
    {
        public int CountVowelStrings1(int n)
        {
            int t = n;
            int p = 0;
            List<string> list = new List<string>();
            list.Add("");
            char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
            while (n != 0)
            {
                List<string> runner = new List<string>();
                for (int j = 0; j < list.Count; j++)
                {
                    for (int i = j; i < vowel.Length; i++)
                    {
                        runner.Add(list[j] + vowel[i].ToString());
                    }
                }
                for (int i = 0; i < runner.Count; i++)
                {
                    list.Add(runner[i]);
                }
                list.RemoveAll(x => x.Length == p);
                p++;
                n--;
            }
            int count = 0;
            foreach (string lis in list)
            {
                Console.WriteLine(lis);
                if (lis.Length == t)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

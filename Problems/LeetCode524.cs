using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class LeetCode524
    {
        public string FindLongestWord(string s, IList<string> d)
        {
            int max = 0;
            List<string> list = new List<string>();
            string result = string.Empty;
            for (int i = 0; i < d.Count; i++)
            {
                for (int j = 0; j < d[i].Length; j++)
                {
                    int count = d[i].Length;
                    for (int k = 0; k < s.Length; k++)
                    {
                        if (d[i][j] == s[k])
                        {
                            j++;
                            count--;
                            if (j >= d[i].Length)
                            {
                                break;
                            }
                        }
                    }
                    if (count == 0)
                    {
                        if (d[i].Length > max)
                        {
                            result = d[i];
                            list.Add(result);
                            max = d[i].Length;
                        }
                        if (d[i].Length == max)
                        {
                            list.Add(d[i]);
                        }
                    }
                }
            }
            return list.Count==0? string.Empty: list.OrderByDescending(x => x.Length).FirstOrDefault(); 
        }
    }
}

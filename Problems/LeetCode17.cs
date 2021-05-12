using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode17
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0)
            {
                return new List<string>();
            }
            string[] mapper = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            IList<string> result = new List<string>();
            result.Add("");
            foreach (char c in digits)
            {
                IList<string> temp = new List<string>();
                for (int i = 0; i < result.Count; i++)
                {
                    string ss = mapper[Convert.ToInt32(c.ToString())];
                    for (int j = 0; j < ss.Length; j++)
                    {
                        temp.Add(result[i] + ss[j].ToString());
                    }
                }
                foreach (var item in temp)
                {
                    result.Add(item.Trim());
                }
            }
            int len = digits.Length;
            IList<string> pass = new List<string>();
            foreach (var item in result)
            {
                if (item.Length == len)
                {
                    pass.Add(item);
                }
            }
            return pass;
        }
    }
}

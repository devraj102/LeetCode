using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public class LeetCode784
    {
        
        public IList<string> LetterCasePermutation(string S)
        {
            IList<string> list = new List<string>();
            int length = Convert.ToInt32(Math.Pow(2, S.Length));
            for (int i = 0; i < length; i++)
            {
                string padd = Convert.ToString(i, 2);
                string binary = padd.PadLeft(S.Length, '0');
                string permutation = string.Empty;
                for (int j = 0; j < binary.Length; j++)
                {
                    if (binary[j] == '1')
                    {
                        if ((int)S[j] >= 65 && (int)S[j] <= 90)
                        {
                            permutation += S[j].ToString().ToLower();
                        }
                        else if ((int)S[j] >= 97 && (int)S[j] <= 122)
                        {
                            permutation += S[j].ToString().ToUpper();
                        }
                    }
                    else
                    {
                        permutation += S[j].ToString();
                    }
                }
                list.Add(permutation);
            }
            var result = list.Distinct<string>();
            return result.ToList<string>();
        }
    }
}

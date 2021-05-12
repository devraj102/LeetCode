using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode890
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            if (words.Length == 0 || pattern.Length == 0)
            {
                return new List<string>();
            }
            IList<string> list = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == pattern.Length)
                {
                    if (IsPatterenMatched(words[i], pattern))
                    {
                        list.Add(words[i]);
                    }
                }
            }
            return list;
        }
        private bool IsPatterenMatched(string word, string pattern)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if(word[i]==word[i+1] && pattern[i] ==pattern[i+1])
                {

                }
                else if (word[i] != word[i + 1] && pattern[i] != pattern[i + 1])
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

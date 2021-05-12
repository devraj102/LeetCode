using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode394
    {
        public string DecodeString(string s)
        {
            //"2[abc]3[cd]ef"
            StringBuilder sb  =new StringBuilder();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '[')
                {
                    i++;
                    string ss = string.Empty;
                    for (; i < s.Length && s[i] != '[' && s[i] != ']'; i++)
                    {
                        ss += s[i].ToString();
                    }
                    stack.Push(ss);
                    i--;
                }
                else if (s[i] == ']')
                {
                    string ss = stack.Pop();
                    int loop = Convert.ToInt32(stack.Pop());
                    for (int p = 0; p < loop; p++)
                    {
                        sb.Append(ss);
                    }
                }
                else if (s[i] >= 48 && (int)s[i] <= 57)
                {
                    string number = string.Empty;
                    for (; i < s.Length && (int)s[i] >= 48 && (int)s[i] <= 57; i++)
                    {
                        number += s[i].ToString();
                    }
                    i--;
                    stack.Push(number);
                }
                else
                {
                    string number = string.Empty;
                    for (; i < s.Length; i++)
                    {
                        number += s[i].ToString();
                    }
                    //i--;
                    stack.Push(number);
                }
            }

            if (stack.Count > 0)
            {
                foreach (var item in stack)
                {
                    sb.Append(item);
                }
            }
            return sb.ToString();
        }
        private void Traverse(string s , int i)
        {
           
        }
        private bool IsLetter(char c)
        {
            if ((int)c >= 97 && (int)c <= 122)
            {
                return true;
            }
            return false;
        }
        private bool IsNumber(char c)
        {
            if ((int)c >= 48 && (int)c <= 57)
            {
                return true;
            }
            return false;
        }
    }
}

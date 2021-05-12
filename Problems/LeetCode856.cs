using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode856
    {
        public int ScoreOfParentheses(string S)
        {
            Stack<char> stack = new Stack<char>();
            int sum = 0;
            foreach (var item in S)
            {
                if (item == '(')
                {
                    stack.Push(item);
                }
                else if (item == ')')
                {
                    sum = 1;
                }
                else if (stack.Count > 0)
                {

                }
            }
            return 0;
        }
    }
}

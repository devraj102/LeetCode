using System.Collections.Generic;

namespace LeetCode
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char bracket in s)
            {
                if (bracket == ')' || bracket == '}' || bracket == ']')
                {
                    stack.TryPeek(out char result);
                    if (result == '(' && bracket == ')')
                    {
                        stack.Pop();
                    }
                    else if (result == '{' && bracket == '}')
                    {
                        stack.Pop();
                    }
                    else if (result == '[' && bracket == ']')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(bracket);
                }
            }
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
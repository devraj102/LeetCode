using System.Collections.Generic;

namespace LeetCode
{
    public class LeetCode20
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var item in s)
            {
                stack.TryPeek(out char result);
                if (result == '(' && item == ')')
                {
                    stack.Pop();
                }
                else if (result == '{' && item == '}')
                {
                    stack.Pop();
                }
                else if (result == '[' && item == ']')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(item);
                }
            }
            return stack.Count == 0 ? true : false;
        }
    }
}

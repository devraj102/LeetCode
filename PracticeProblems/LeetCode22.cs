using System.Collections.Generic;

namespace LeetCode
{
    public class LeetCode22
    {
        List<string> list;
        public IList<string> GenerateParenthesis(int n)
        {
            list = new List<string>();
            List<string> result = new List<string>();
            GenerateAllPermutation(0, 2*n, "");
            for (int i = 0; i < list.Count; i++)
            {
                if (ValidateParenthesis(list[i]))
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }
        public void GenerateAllPermutation(int l, int r, string s)
        {
            if (l == r)
            {
                list.Add(s);                
                return;
            }
            GenerateAllPermutation(l + 1, r, s+"(");
            GenerateAllPermutation(l + 1, r, s+ ")");
        }

        public bool ValidateParenthesis(string pattern)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var item in pattern)
            {
                stack.TryPeek(out char result);
                if (result == '(' && item == ')')
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

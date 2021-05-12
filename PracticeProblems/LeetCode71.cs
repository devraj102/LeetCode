using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode71
    {
        public string SimplifyPath(string path)
        {
            Stack<string> stack = new Stack<string>();
            string[] split = path.Split('/');
            foreach (var item in split)
            {
                if (item.Length > 0)
                {
                    if (item == ".")
                    {

                    }
                    else if (item == "..")
                    {
                        stack.TryPop(out string pop);
                    }
                    else
                    {
                        stack.Push("/" + item);
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (var item in stack)
            {
                sb.Insert(0, item);
            }
            return sb.ToString().Length == 0 ? "/" : sb.ToString();
        }
    }
}

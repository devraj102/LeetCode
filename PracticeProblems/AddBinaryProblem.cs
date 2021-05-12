using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class AddBinaryProblem
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            Stack<int> stackA = new Stack<int>();
            Stack<int> stackB = new Stack<int>();
            int i = 0;
            for (; i < a.Length; i++)
            {
                stackA.Push(Convert.ToInt32(a[i].ToString()));
            }
            i = 0;
            for (; i < b.Length; i++)
            {
                stackB.Push(Convert.ToInt32(b[i].ToString()));
            }
            int j = 0;
            int remainder = 0;

            while (stackA.Count > 0 && stackB.Count > 0)
            {
                int sum = stackA.Pop() + stackB.Pop() + remainder;
                if (sum > 1)
                {
                    remainder = 1;
                    sum = sum % 2;
                }
                else
                {
                    remainder = 0;
                }
                sb.Insert(0,sum);
            }
            while (stackA.Count>0)
            {
                int sum = stackA.Pop() + remainder;
                if (sum > 1)
                {
                    remainder = 1;
                    sum = sum % 2;
                }
                else
                {
                    remainder = 0;
                }
                sb.Insert(0,sum);
            }
            while (stackB.Count>0)
            {
                int sum = stackB.Pop() + remainder;
                if (sum > 1)
                {
                    remainder = 1;
                    sum = sum % 2;
                }
                else
                {
                    remainder = 0;
                }
                sb.Insert(0,sum);
            }
            if(remainder>0)
            {
                sb.Insert(0,remainder);
            }
            return sb.ToString();
        }
    }
}

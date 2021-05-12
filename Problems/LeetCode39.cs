using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class LeetCode39
    {
        List<List<int>> listOfList;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            listOfList = new List<List<int>>();
            Traverse(candidates, 0, 0, target ,new List<int>(), candidates[0]);
            return null;
        }

        public void Traverse(int[] candidates, int i,int valid, int target, List<int> list, int currentItem)
        {
            if (target == valid)
            {
                Console.WriteLine("---");
                return;
            }
            if (valid < 0 || valid > target)
            {
                list.Remove(currentItem);
                return;
            }
            list.Add(candidates[i]);
            Traverse(candidates, i+1, valid + candidates[i], target, list, candidates[i]);
            list.Remove(candidates[i]);
            list.Add(candidates[i]);
            Traverse(candidates, i, valid + candidates[i], target, list, candidates[i]);
            //list.Remove(candidates[i]);
        }
    }
}

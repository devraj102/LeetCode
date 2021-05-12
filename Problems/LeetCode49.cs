using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class LeetCode49
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            HashSet<string> set = new HashSet<string>();
            IList<List<string>> listOfList = new List<List<string>>();
            if (strs.Length == 0)
            {
                return listOfList.Cast<IList<string>>().ToList();
            }
            List<KeyValue> dict = new List<KeyValue>();
            foreach (var item in strs)
            {
                string ss = string.Join("", item.ToCharArray().OrderBy(x => x));
                set.Add(ss);
                dict.Add(new KeyValue() { Key = item, Value = ss });
            }

            List<string> group = new List<string>();
            foreach (var item in set)
            {
                var dd = dict.Where(x => x.Value == item).Select(x => x.Key).ToList<string>();
                listOfList.Add(dd);
            }
            return listOfList.Cast<IList<string>>().ToList();
        }
    }
    public class KeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}

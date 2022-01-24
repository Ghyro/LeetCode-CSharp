using System.Collections.Generic;
using System.Linq;

namespace Medium
{
    // Issue: 49

    //Given an array of strings strs, group the anagrams together.You can return the answer in any order.
    //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
    //typically using all the original letters exactly once.

    class GroupAnagrams
    {
        public IList<IList<string>> Group(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return new List<IList<string>>();
            var hash = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var key = new string(str.OrderBy(x => x).ToArray());
                if (!hash.ContainsKey(key))
                    hash.Add(key, new List<string>());
                hash[key].Add(str);
            }
            return hash.Values.ToList();
        }
    }
}

using System.Collections.Generic;

namespace Easy
{
    //Issue: 242

    //Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
    //typically using all the original letters exactly once.

    class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s == null || t == null)
            {
                return false;
            }
            if (s.Length != t.Length)
            {
                return false;
            }
            var dct = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dct.ContainsKey(s[i]))
                {
                    dct[s[i]]++;
                }
                else
                {
                    dct.Add(s[i], 1);
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dct.ContainsKey(t[i]))
                {
                    dct[t[i]]--;
                }
            }
            foreach (var item in dct)
            {
                if (item.Value > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

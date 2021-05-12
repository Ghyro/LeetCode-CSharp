using System.Collections.Generic;

namespace Easy
{
  class DetermineIfStringHalvesAreAlike
  {
    public bool HalvesAreAlike(string s)
    {
      var str = "";
      str.ToLower();
      char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
      var dict = new Dictionary<char, bool>();
      for (int i = 0; i < vowels.Length; i++)
        dict.Add(vowels[i], true);
      int left = 0;
      int right = 0;
      for (int i = 0; i < s.Length / 2; i++)
      {
        if (dict.ContainsKey(s[i]))
          left++;
      }
      for (int j = s.Length / 2; j < s.Length; j++)
      {
        if (dict.ContainsKey(s[j]))
          right++;
      }
      return left == right;
    }
  }
}

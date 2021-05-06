using System.Collections.Generic;

namespace Easy
{
  class CountTheNumberOfConsistentStrings
  {
    public int CountConsistentStrings(string allowed, string[] words)
    {
      var result = words.Length;
      var dict = new Dictionary<char, bool>();
      for (int i = 0; i < allowed.Length; i++)
      {
        if (!dict.ContainsKey(allowed[i]))
          dict.Add(allowed[i], true);
      }
      foreach (var word in words)
      {
        foreach (var ch in word)
        {
          if (!dict.ContainsKey(ch))
          {
            result--;
            break;
          }
        }
      }
      return result;
    }
  }
}

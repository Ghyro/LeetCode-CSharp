using System.Collections.Generic;

namespace Medium
{
  class MinimumNumberOfStepsToMakeTwoStringsAnagram
  {
    public int MinSteps(string s, string t)
    {
      int result = 0;
      var dctLeft = new Dictionary<char, int>();
      var dctRight = new Dictionary<char, int>();

      foreach (var ch in s)
      {
        if (!dctLeft.ContainsKey(ch))
          dctLeft.Add(ch, 1);
        else
          dctLeft[ch]++;
      }

      foreach (var ch in t)
      {
        if (!dctRight.ContainsKey(ch))
          dctRight.Add(ch, 1);
        else
          dctRight[ch]++;
      }

      foreach (var right in dctRight)
      {
        if (dctLeft.ContainsKey(right.Key))
        {
          if (right.Value > dctLeft[right.Key])
          {
            var diff = right.Value - dctLeft[right.Key];
            result += diff;
          }
        }
        else
          result += right.Value;
      }
      return result;
    }
  }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Easy
{
  class TruncateSentence
  {
    public string Truncate(string s, int k)
    {
      StringBuilder str = new StringBuilder();
      for (int i = 0; i < s.Length; i++)
      {
        if (k == 0)
          break;
        if (s[i] != ' ')
          str.Append(s[i]);
        else
        {
          str.Append(" ");
          k--;
        }
      }
      if (str[str.Length - 1] == ' ')
        str.Remove(str.Length - 1, 1);
      return str.ToString();
    }
  }
}

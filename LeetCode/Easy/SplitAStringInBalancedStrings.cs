using System;
using System.Collections.Generic;
using System.Text;

namespace Easy
{
  class SplitAStringInBalancedStrings
  {
    public int BalancedStringSplit(string s)
    {
      int splits = 0;
      int counter = 0;
      for (int i = 0; i < s.Length; i++)
      {
        switch (s[i])
        {
          case 'R':
            counter++;
            break;
          case 'L':
            counter--;
            break;
        }
        if (counter == 0)
          splits++;
      }
      return splits;
    }
  }
}

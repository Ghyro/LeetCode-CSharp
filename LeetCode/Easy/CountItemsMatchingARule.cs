using System.Collections.Generic;

namespace Easy
{
  class CountItemsMatchingARule
  {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
      int result = 0;
      foreach (var item in items)
      {
        switch (ruleKey)
        {
          case "type":
            if (item[0] == ruleValue)
              result++;
            break;
          case "color":
            if (item[1] == ruleValue)
              result++;
            break;
          case "name":
            if (item[2] == ruleValue)
              result++;
            break;
        }
      }
      return result;
    }
  }
}

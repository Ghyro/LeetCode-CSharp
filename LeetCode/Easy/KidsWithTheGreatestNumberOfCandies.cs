using System.Collections.Generic;

namespace Easy
{
  class KidsWithTheGreatestNumberOfCandies
  {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
      bool[] result = new bool[candies.Length];
      int max = candies[0];
      for (int i = 0; i < candies.Length; i++)
      {
        if (candies[i] > max)
          max = candies[i];
      }
      for (int i = 0; i < candies.Length; i++)
        result[i] = candies[i] + extraCandies >= max;
      return result;
    }
  }
}

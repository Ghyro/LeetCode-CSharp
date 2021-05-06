using System;

namespace Medium
{
	class MaximumIceCreamBars
	{
    public int MaxIceCream(int[] costs, int coins)
    {
      Array.Sort(costs);
      int spentSum = 0;
      for (int i = 0; i < costs.Length; i++)
      {
        if (costs[i] <= coins)
        {
          spentSum++;
          coins -= costs[i];
        }
      }
      return spentSum;
    }
  }
}

using System;

namespace Easy
{
  class CanMakeArithmeticProgressionFromSequence
  {
    public bool CanMakeArithmeticProgression(int[] arr)
    {
      Array.Sort(arr);
      int comparer = arr[1] - arr[0];
      for (int i = 2; i < arr.Length; i++)
      {
        if (arr[i] - arr[i - 1] != comparer)
          return false;
      }
      return true;
    }
  }
}

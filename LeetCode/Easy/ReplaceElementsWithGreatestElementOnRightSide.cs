namespace Easy
{
  class ReplaceElementsWithGreatestElementOnRightSide
  {
    public int[] ReplaceElements(int[] arr)
    {
      int[] result = new int[arr.Length];
      for (int i = 0; i < arr.Length; i++)
      {
        int greatestValue = 0;
        for (int j = i + 1; j < arr.Length; j++)
        {
          if (greatestValue < arr[j])
          {
            greatestValue = arr[j];
            result[i] = greatestValue;
          }
        }
      }
      result[result.Length - 1] = -1;
      return result;
    }
  }
}

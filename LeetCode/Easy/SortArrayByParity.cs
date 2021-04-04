namespace Easy
{
  class SortArrayByParity
  {
    public int[] SortArrayByParityFunc(int[] A)
    {
      int[] result = new int[A.Length];
      int start = 0;
      int end = A.Length - 1;
      for (int i = 0; i < A.Length; i++)
      {
        if (A[i] % 2 == 0)
        {
          result[start] = A[i];
          start++;
        }
        else
        {
          result[end] = A[i];
          end--;
        }
      }
      return result;
    }
  }
}

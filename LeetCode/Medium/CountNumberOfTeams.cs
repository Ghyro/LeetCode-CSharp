namespace Medium
{
  class CountNumberOfTeams
  {
    public int NumTeams(int[] rating)
    {
      int result = 0;
      int arrLength = rating.Length;
      for (int i = 0; i < arrLength; i++)
      {
        for (int j = i + 1; j < arrLength; j++)
        {
          for (int k = j + 1; k < arrLength; k++)
          {
            if ((rating[i] < rating[j] && rating[j] < rating[k])
                || (rating[i] > rating[j] && rating[j] > rating[k]))
              result++;
          }
        }
      }
      return result;
    }
  }
}

namespace Easy
{
  class CountOfMatchesInournament
  {
    public int NumberOfMatches(int n)
    {
      if (n == 1)
        return 0;
      if (n % 2 == 0)
        return n / 2 + NumberOfMatches(n / 2);
      return n / 2 + NumberOfMatches(n / 2 + 1);
    }
  }
}

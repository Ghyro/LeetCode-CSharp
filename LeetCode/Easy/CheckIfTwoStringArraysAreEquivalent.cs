namespace Easy
{
  class CheckIfTwoStringArraysAreEquivalent
  {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
      return string.Concat(word1) == string.Concat(word2);
    }
  }
}

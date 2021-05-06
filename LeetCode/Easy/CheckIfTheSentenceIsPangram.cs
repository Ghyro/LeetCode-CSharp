using System.Collections.Generic;

namespace Easy
{
  class CheckIfTheSentenceIsPangram
  {
    public bool CheckIfPangram(string sentence)
    {
      Dictionary<char, int> dct = new Dictionary<char, int>();
      for (int i = 0; i < sentence.Length; i++)
      {
        if (!dct.ContainsKey(sentence[i]))
          dct.Add(sentence[i], 1);
      }
      return dct.Count == 26;
    }
  }
}

using System;
using System.Linq;

namespace Easy
{
  class ReverseWordsInAString
  {
    public string ReverseWords(string s)
    {      
      return string.Join(" ", s.Split(' ').Select(x => new string(x.Reverse().ToArray())));
    }
  }
}

using System.Text;

namespace Easy
{
  class DefangingAnIPAddress
  {
    public string DefangIPaddr(string address)
    {
      var result = new StringBuilder();
      foreach (var t in address)
      {
        if (t == '.')
            result.Append("[.]");
        else
            result.Append(t);
      }
      return result.ToString();
    }
  }
}

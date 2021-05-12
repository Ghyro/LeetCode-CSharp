using System.Collections.Generic;

namespace Medium
{
  public class DesignBrowserHistory
  {
    private Stack<string> backHistory;
    private Stack<string> forwardHistory;

    public DesignBrowserHistory(string homepage)
    {
      backHistory = new Stack<string>();
      forwardHistory = new Stack<string>();
      backHistory.Push(homepage);
    }

    public void Visit(string url)
    {
      forwardHistory.Clear();
      backHistory.Push(url);
    }

    public string Back(int steps)
    {
      for (int i = 0; i < steps; i++)
      {
        if (backHistory.Count <= 1)
          break;

        forwardHistory.Push(backHistory.Peek());
        backHistory.Pop();
      }
      return backHistory.Peek(); ;
    }

    public string Forward(int steps)
    {
      for (int i = 0; i < steps; i++)
      {
        if (forwardHistory.Count == 0)
          break;

        backHistory.Push(forwardHistory.Peek());
        forwardHistory.Pop();
      }
      return backHistory.Peek();
    }
  }
}

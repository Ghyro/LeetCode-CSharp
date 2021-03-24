using System.Text;

namespace Easy
{
  class GoalParserInterpretation
  {
    public string Interpret(string command)
    {
      StringBuilder result = new StringBuilder();
      for (int i = 0; i < command.Length; i++)
      {
        switch (command[i])
        {
          case '(':
          {
            if (command[i + 1] == ')')
            {
              result.Append('o');
              i++;
            }
            continue;
          }
          case ')':
            continue;
          default:
            result.Append(command[i]);
            break;
        }
      }
      return result.ToString();
    }
  }
}

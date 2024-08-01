using System;

public static class ConsoleHelper
{
  public static string CaptureConsoleOutput(Action action)
  {
    using (var sw = new System.IO.StringWriter())
    {
      var originalOut = Console.Out;
      Console.SetOut(sw);
      try
      {
        action();
        return sw.ToString();
      }
      finally
      {
        Console.SetOut(originalOut);
      }
    }
  }
}
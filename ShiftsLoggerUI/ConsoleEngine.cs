using Spectre.Console;

namespace ShiftsLoggerUI;

internal static class ConsoleEngine
{
  internal static string GetChoiceSelector(string title, string[] choices)
  {
    SelectionPrompt<string> prompt = new SelectionPrompt<string>()
                                     .Title(title)
                                     .AddChoices(choices)
                                     .HighlightStyle(Color.Cyan1);

    string choice = AnsiConsole.Prompt(prompt);

    return choice;
  }

  internal static void ShowTitle()
  {
    AnsiConsole.Clear();

    Rule rule = new("Shifts Logger");
    rule.Centered().HeavyBorder().Style = new Style(Color.Cyan1);

    AnsiConsole.Write(rule);
  }
}
using Spectre.Console;

namespace ShiftsLoggerUI;

internal class AppEngine
{
  internal bool IsRunning { get; set; }

  public AppEngine()
  {
    IsRunning = true;
  }

  internal void MainMenu()
  {
    ConsoleEngine.ShowTitle();

    string choice = ConsoleEngine.GetChoiceSelector("What you would like to do?", ["Show Shifts", "Create Shift", "Update Shift", "Delete Shift", "Quit"]);

    switch (choice)
    {
      case "Show Shifts":
        break;
      case "Create Shift":
        break;
      case "Update Shift":
        break;
      case "Delete Shift":
        break;
      case "Quit":
        AnsiConsole.Clear();
        AnsiConsole.Markup("[cyan1]GOODBYE[/]");
        IsRunning = false;
        break;
    }
  }
}

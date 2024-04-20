using ShiftsLoggerUI.Models;
using ShiftsLoggerUI.Services;
using Spectre.Console;

namespace ShiftsLoggerUI;

internal class AppEngine
{
  internal bool IsRunning { get; set; }
  private HttpClient Client { get; set; }

  public AppEngine()
  {
    IsRunning = true;
    Client = new();
    Client.DefaultRequestHeaders.Clear();
    Client.DefaultRequestHeaders.Add("Accept", "application/json");
  }

  internal async Task MainMenu()
  {
    ConsoleEngine.ShowTitle();

    string choice = ConsoleEngine.GetChoiceSelector("What you would like to do?", ["Show Shifts", "Create Shift", "Update Shift", "Delete Shift", "Quit"]);

    switch (choice)
    {
      case "Show Shifts":
        List<Shift>? shifts = await ShiftsService.GetShifts(Client);
        ConsoleEngine.ShowShiftsTable(shifts);
        PressAnyKey();
        break;
      case "Create Shift":
        await ShiftsService.CreateShift(Client, "Test from C#", DateTime.Now, DateTime.Now);
        PressAnyKey();
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

  private void PressAnyKey()
  {
    AnsiConsole.Markup("\n\n[cyan1]Press any key to continue.[/]\n");
    Console.ReadKey();
  }
}

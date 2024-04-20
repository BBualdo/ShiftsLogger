using ShiftsLoggerUI.Helpers;
using Spectre.Console;

namespace ShiftsLoggerUI;

internal static class UserInput
{
  internal static string GetName()
  {
    string name = AnsiConsole.Ask<string>("Enter [cyan1]employee name[/] or type 0 to cancel: ");

    if (name == "0") return name;

    while (!EmployeeNameValidator.IsValid(name))
    {
      name = AnsiConsole.Ask<string>("Try again: ");
      if (name == "0") return name;
    }

    return name;
  }

  internal static string GetStartDate(string name)
  {
    string startDate = AnsiConsole.Ask<string>($"Enter [cyan1]date and time[/] when [fuchsia]{name}[/] started work or type 0 to cancel. Correct format: [cyan1](dd-MM-yyyy HH:mm)[/]: ");

    if (startDate == "0") return startDate;

    while (!DateTimeValidator.IsValid(startDate))
    {
      startDate = AnsiConsole.Ask<string>("Try again: ");
      if (startDate == "0") return startDate;
    }

    return startDate;
  }

  internal static string GetEndDate(string startDate, string name)
  {
    string endDate = AnsiConsole.Ask<string>($"Enter [cyan1]date and time[/] when [fuchsia]{name}[/] finished work or type 0 to cancel. Correct format: [cyan1](dd-MM-yyyy HH:mm)[/]: ");

    if (endDate == "0") return endDate;

    while (!DateTimeValidator.IsValid(endDate))
    {
      endDate = AnsiConsole.Ask<string>("Try again: ");
      if (endDate == "0") return endDate;
    }

    while (!DateTimeValidator.IsEndDateLater(startDate, endDate))
    {
      endDate = AnsiConsole.Ask<string>("Try again: ");
      if (endDate == "0") return endDate;
    }

    return endDate;
  }
}

namespace ShiftsLogger.BBualdo.Models;

public class Shift
{
  public int ShiftId { get; set; }
  public string? EmployeeName { get; set; }
  public DateTime StartDate { get; set; }
  public DateTime EndDate { get; set; }
}

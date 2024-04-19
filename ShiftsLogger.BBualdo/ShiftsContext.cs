using Microsoft.EntityFrameworkCore;
using ShiftsLogger.BBualdo.Models;

namespace ShiftsLogger.BBualdo;

public class ShiftsContext : DbContext
{
  public ShiftsContext(DbContextOptions<ShiftsContext> options) : base(options) { }

  public DbSet<Shift> Shifts { get; set; }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShiftsLogger.BBualdo.Models;

namespace ShiftsLogger.BBualdo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShiftsController : ControllerBase
{
  private readonly ShiftsContext _context;

  public ShiftsController(ShiftsContext context)
  {
    _context = context;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<Shift>>> GetShifts()
  {
    if (_context.Shifts == null) return NotFound();

    return await _context.Shifts.ToListAsync();
  }
}

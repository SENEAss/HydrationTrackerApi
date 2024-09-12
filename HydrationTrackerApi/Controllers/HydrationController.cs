using HydrationTrackerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class HydrationController : ControllerBase
{
    private readonly HydrationContext _context;

    public HydrationController(HydrationContext context)
    {
        _context = context;
    }

    // POST: api/Hydration
    [HttpPost]
    public async Task<ActionResult> AddHydrationRecord(HydrationRecord record)
    {
        _context.HydrationRecords.Add(record);
        await _context.SaveChangesAsync();
        return Ok(record);
    }

    // GET: api/Hydration/{userId}
    [HttpGet("{userId}")]
    public async Task<ActionResult<IEnumerable<HydrationRecord>>> GetHydrationRecords(int userId)
    {
        return await _context.HydrationRecords
            .Where(record => record.UserId == userId)
            .ToListAsync();
    }
}

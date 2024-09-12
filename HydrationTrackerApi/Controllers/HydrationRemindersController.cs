using HydrationTrackerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HydrationTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HydrationRemindersController : ControllerBase
    {
        private readonly HydrationContext _context;

        public HydrationRemindersController(HydrationContext context)
        {
            _context = context;
        }

        // GET: api/HydrationReminders/{userId}
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<HydrationReminder>>> GetReminders(int userId)
        {
            return await _context.HydrationReminders
                .Where(reminder => reminder.UserId == userId)
                .ToListAsync();
        }

        // POST: api/HydrationReminders
        [HttpPost]
        public async Task<ActionResult<HydrationReminder>> CreateReminder(HydrationReminder reminder)
        {
            _context.HydrationReminders.Add(reminder);
            await _context.SaveChangesAsync();
            return Ok(reminder);
        }
    }
}

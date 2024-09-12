using HydrationTrackerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HydrationTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HydrationGoalsHistoryController : ControllerBase
    {
        private readonly HydrationContext _context;

        public HydrationGoalsHistoryController(HydrationContext context)
        {
            _context = context;
        }

        // GET: api/HydrationGoalsHistory/{userId}
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<HydrationGoalsHistory>>> GetGoalsHistory(int userId)
        {
            return await _context.HydrationGoalsHistories
                .Where(history => history.UserId == userId)
                .ToListAsync();
        }

        // POST: api/HydrationGoalsHistory
        [HttpPost]
        public async Task<ActionResult<HydrationGoalsHistory>> AddGoalHistory(HydrationGoalsHistory history)
        {
            _context.HydrationGoalsHistories.Add(history);
            await _context.SaveChangesAsync();
            return Ok(history);
        }
    }
}

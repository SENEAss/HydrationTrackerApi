using HydrationTrackerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HydrationTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsSentController : ControllerBase
    {
        private readonly HydrationContext _context;

        public NotificationsSentController(HydrationContext context)
        {
            _context = context;
        }

        // GET: api/NotificationsSent/{userId}
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<NotificationsSent>>> GetNotifications(int userId)
        {
            return await _context.NotificationsSent
                .Where(notification => notification.UserId == userId)
                .ToListAsync();
        }

        // POST: api/NotificationsSent
        [HttpPost]
        public async Task<ActionResult<NotificationsSent>> AddNotification(NotificationsSent notification)
        {
            _context.NotificationsSent.Add(notification);
            await _context.SaveChangesAsync();
            return Ok(notification);
        }
    }
}

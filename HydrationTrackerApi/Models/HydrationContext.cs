using Microsoft.EntityFrameworkCore;

namespace HydrationTrackerApi.Models // Assurez-vous que cet espace de noms correspond à celui utilisé dans Program.cs
{
    public class HydrationContext : DbContext
    {
        public HydrationContext(DbContextOptions<HydrationContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<HydrationRecord> HydrationRecords { get; set; }
        public DbSet<HydrationReminder> HydrationReminders { get; set; }
        public DbSet<HydrationGoalsHistory> HydrationGoalsHistories { get; set; }
        public DbSet<NotificationsSent> NotificationsSent { get; set; }

    }
}

namespace HydrationTrackerApi.Models
{
    public class HydrationRecord
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Amount { get; set; }
        public DateTime DateTime { get; set; }
        public User User { get; set; }
    }
}


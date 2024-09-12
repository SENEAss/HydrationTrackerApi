namespace HydrationTrackerApi.Models
{
    public class NotificationsSent
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string NotificationText { get; set; }
        public DateTime SentAt { get; set; }
        public User User { get; set; }
    }
}

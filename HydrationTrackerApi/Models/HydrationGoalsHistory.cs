namespace HydrationTrackerApi.Models
{
    public class HydrationGoalsHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal OldGoal { get; set; }
        public decimal NewGoal { get; set; }
        public DateTime ChangedAt { get; set; }
        public User User { get; set; }
    }
}

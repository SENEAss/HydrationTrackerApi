namespace HydrationTrackerApi.Models
{
    public class HydrationReminder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public TimeSpan ReminderTime { get; set; }  // Utilisation de TimeSpan pour l'heure du rappel
        public User User { get; set; }
    }
}


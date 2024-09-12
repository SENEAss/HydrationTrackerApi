namespace HydrationTrackerApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }   // Nullable
        public string? Email { get; set; }  // Nullable
        public double HydrationGoal { get; set; }
        public ICollection<HydrationRecord>? HydrationRecords { get; set; }  // Nullable
    }

}

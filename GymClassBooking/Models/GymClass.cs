namespace GymClassBooking.Models
{
    public class GymClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime { get { return StartTime + Duration; } }
        public string Description { get; set; }

        public ICollection<ApplicationUserGymClass> AttendingMembers { get; set; }
    }
}

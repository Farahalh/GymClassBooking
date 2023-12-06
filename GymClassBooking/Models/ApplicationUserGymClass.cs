namespace GymClassBooking.Models
{
    public class ApplicationUserGymClass
    {
        public string ApplicationUserId { get; set; }
        public int GymClassId { get; set; }

        public ApplicationUser User { get; set; }
        public GymClass GumClass { get; set; }
    }
}

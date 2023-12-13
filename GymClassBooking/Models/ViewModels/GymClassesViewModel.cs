namespace GymClassBooking.Models.ViewModels
{
    public class GymClassesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }

        public string Description { get; set; }
        public bool Attending { get; set; }
    }
}

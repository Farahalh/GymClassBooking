using Microsoft.AspNetCore.Identity;

namespace GymClassBooking.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }
}

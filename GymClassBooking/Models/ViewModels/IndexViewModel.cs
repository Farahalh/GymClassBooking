namespace GymClassBooking.Models.ViewModels
{
    public class IndexViewModel
    {
         public IEnumerable<GymClassesViewModel> GymClasses { get; set; } = new List<GymClassesViewModel>();
    }
}

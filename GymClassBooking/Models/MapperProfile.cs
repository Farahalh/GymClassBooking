using AutoMapper;
using GymClassBooking.Models.ViewModels;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.Security.Claims;

namespace GymClassBooking.Models
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<GymClass, GymClassesViewModel>()
                .ForMember(dest => dest.Attending, from =>
                from.MapFrom<AttendingResolver>());

            CreateMap <IEnumerable<GymClass>, IndexViewModel>()
                .ForMember(dest => dest.GymClasses, from =>
                from.MapFrom(global => global.ToList()));
        }
    }

    public class AttendingResolver : IValueResolver<GymClass, GymClassesViewModel, bool>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AttendingResolver(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool Resolve(GymClass source, GymClassesViewModel destination, bool destMember, ResolutionContext context)
        {
            return source.AttendingMembers is null ? false :
                source.AttendingMembers.Any(a => a.ApplicationUserId ==
                _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        }
    }
}

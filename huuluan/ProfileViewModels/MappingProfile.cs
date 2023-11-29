using AutoMapper;
using huuluan.Domain.Models;
using huuluan.ViewModels;

namespace huuluan.ProfileViewModels
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category,CategoryViewModel>();
            CreateMap<Company, CompanyViewModel>();
            
        }
    }
}

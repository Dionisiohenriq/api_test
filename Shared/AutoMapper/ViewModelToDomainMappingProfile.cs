using api_test.Domain.Entities;
using apit_test.Application.ViewModels;
using AutoMapper;

namespace apit_test.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<VirtualCardViewModel, VirtualCard>();
        }
        
    }
}

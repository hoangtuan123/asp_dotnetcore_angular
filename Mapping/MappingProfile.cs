using AutoMapper;
using asp_core_angular.Controllers.Resources;
using asp_core_angular.Models;
namespace asp_core_angular.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
        }        
    }
}
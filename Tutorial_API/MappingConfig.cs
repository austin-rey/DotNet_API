using AutoMapper;
using Tutorial_API.Models;
using Tutorial_API.Models.Dto;

namespace Tutorial_API
{
    public class MappingConfig: Profile
    {
        public MappingConfig() { 
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
        }
    }
}

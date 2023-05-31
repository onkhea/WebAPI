using AutoMapper;
using WebAPI.Dto;
using WebAPI.Models;

namespace WebAPI.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}

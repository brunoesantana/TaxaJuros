using AutoMapper;
using TaxaJuros.CrossCutting.DTO.Taxa;
using TaxaJuros.Domain;

namespace TaxaJuros.Api.Mapper
{
    public class MapperEntity2Dto : Profile
    {
        public MapperEntity2Dto()
        {
            CreateMap<Taxa, TaxaDTO>();
        }
    }
}
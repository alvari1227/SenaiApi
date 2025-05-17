using AutoMapper;
using WebApplication1.DTos;
using WebApplication1.Entidades;

namespace WebApplication1.Mappers
{
    public class EscolaMapper : Profile
    {
        public EscolaMapper() {
            CreateMap<EscolaDTo, Escola>().ReverseMap();

        }
    }
}

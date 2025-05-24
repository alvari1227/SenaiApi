using AutoMapper;
using WebApplication1.DTos;
using WebApplication1.Entidades;

namespace WebApplication1.Mappers
{
    public class EndereçoMapper : Profile
    {
        public EndereçoMapper()
        {
            CreateMap<EndereçoDTo, Endereço>().ReverseMap();

            CreateMap<EndereçoDTo, Endereço>().ReverseMap();
        }
    }
}

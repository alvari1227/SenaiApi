using AutoMapper;
using WebApplication1.DTos;
using WebApplication1.Entidades;

namespace WebApplication1.Mappers
{
    public class ProfessorMapper : Profile
    {
        public ProfessorMapper()
        {
            CreateMap<ProfessorDTo, Professor>().ReverseMap();

            CreateMap<ProfessorDTo, Professor>().ReverseMap();
        }
    }
}

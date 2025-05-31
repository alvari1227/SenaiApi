using AutoMapper;
using WebApplication1.DTos;
using WebApplication1.Entidades;
using WebApplication1.Repositorios.Interfaces;

namespace WebApplication1.Serviços.Interfaces
{
    public class ProfessorServiçe : IProfessorServiçe
    {
        private readonly IMapper _mapper;
        private readonly IProfessorRepositori _professorRepository;

        public ProfessorServiçe(IMapper mapper, IProfessorRepositori professorRepository)
        {
            _mapper = mapper;
            _professorRepository = professorRepository;
        }

        public ProfessorServiçe(IProfessorRepositori professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public void Salvar(ProfessorDTo professorDTo)
        {
            var professor = _mapper.Map<Professor>(professorDTo);
            _professorRepository.Salvar(professor);
        }
        public List<ProfessorDTo> PegarTodos()
        {
            var professor = _professorRepository.PegarTodos();
            return _mapper.Map<List<ProfessorDTo>>(professor);
        }

        public bool Remover(long id)
        {
            return _professorRepository.Remover(id);
        }

        public void Editar(ProfessorDTo model)
        {
            var professor = _professorRepository.ObterPorId(model.Id);
            _mapper.Map(model, professor);

            _professorRepository.Salvar(professor);
        }

        
    }
}


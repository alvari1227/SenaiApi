using AutoMapper;
using WebApplication1.DTos;
using WebApplication1.Entidades;
using WebApplication1.Repositorios.Interfaces;
using WebApplication1.Serviços.Interfaces;

namespace WebApplication1.Serviços
{
    public class EscolaServiçe : IEscolaServiçe
    {
        private readonly IMapper _mapper;
        private readonly IEscola _escolaRepository;
        
        public EscolaServiçe(IMapper mapper, IEscola escolaRepository)
        {
            _mapper = mapper;
            _escolaRepository = escolaRepository;
        }

        public EscolaServiçe(IEscola escolaRepository) {
        _escolaRepository = escolaRepository;
        }
        
        public void Salvar(EscolaDTo escolaDTo)
        {
            var escola = _mapper.Map<Escola>(escolaDTo);
            _escolaRepository.Salvar(escola);
        }
        public List<EscolaDTo> PegarTodos()
        {
            var escolas = _escolaRepository.PegarTodos();
            return _mapper.Map<List<EscolaDTo>>(escolas);
        }

    }
}

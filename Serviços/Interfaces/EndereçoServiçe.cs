using AutoMapper;
using WebApplication1.DTos;
using WebApplication1.Entidades;
using WebApplication1.Repositorios.Interfaces;

namespace WebApplication1.Serviços.Interfaces
{
    public class EndereçoServiçe : IEndereçoServiçe
    {
        private readonly IMapper _mapper;
        private readonly IEndereçoRepositori _endereçoRepository;

        public EndereçoServiçe(IMapper mapper, IEndereçoRepositori endereçoRepository)
        {
            _mapper = mapper;
            _endereçoRepository = endereçoRepository;
        }

        public EndereçoServiçe(IEndereçoRepositori endereçoRepository)
        {
            _endereçoRepository = endereçoRepository;
        }

        public void Salvar(EndereçoDTo endereçoDTo)
        {
            var endereço = _mapper.Map<Endereço>(endereçoDTo);
            _endereçoRepository.Salvar(endereço);
        }
        public List<EndereçoDTo> PegarTodos()
        {
            var endereço = _endereçoRepository.PegarTodos();
            return _mapper.Map<List<EndereçoDTo>>(endereço);
        }

        public bool Remover(long id)
        {
            return _endereçoRepository.Remover(id);
        }

        public void Editar(EscolaEdiçaoDTo model)
        {
            var endereço = _endereçoRepository.ObterPorId(model.Id);
            _mapper.Map(model, endereço);

            _endereçoRepository.Salvar(endereço);
        }

        public void Editar(EndereçoDTo endereço)
        {
            throw new NotImplementedException();
        }
    }
}

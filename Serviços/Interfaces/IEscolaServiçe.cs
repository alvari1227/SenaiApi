using WebApplication1.DTos;
using WebApplication1.Entidades;

namespace WebApplication1.Serviços.Interfaces
{
    public interface IEscolaServiçe
    {
        public List<EscolaDTo> PegarTodos();
        void Salvar(EscolaDTo escola);
    }
}

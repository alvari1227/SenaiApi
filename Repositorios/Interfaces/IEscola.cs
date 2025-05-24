using AutoMapper;
using WebApplication1.Entidades;

namespace WebApplication1.Repositorios.Interfaces
{
    public interface IEscola
    {
        List<Escola>PegarTodos();
        void Salvar(Escola escola);

        bool Remover(long id);
        Escola ObterPorId(long id);
    }
}

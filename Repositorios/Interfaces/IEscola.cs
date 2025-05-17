using WebApplication1.Entidades;

namespace WebApplication1.Repositorios.Interfaces
{
    public interface IEscola
    {
        List<Escola>PegarTodos();
        void Salvar(Escola escola);
    }
}

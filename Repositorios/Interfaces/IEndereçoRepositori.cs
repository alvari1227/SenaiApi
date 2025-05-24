using WebApplication1.Entidades;

namespace WebApplication1.Repositorios.Interfaces
{
    public interface IEndereçoRepositori
    {
        List<Endereço> PegarTodos();
        void Salvar(Endereço endereço);

        bool Remover(long id);
        Endereço ObterPorId(long id);
    }
}

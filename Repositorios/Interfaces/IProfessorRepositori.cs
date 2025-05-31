using WebApplication1.Entidades;

namespace WebApplication1.Repositorios.Interfaces
{
    public interface IProfessorRepositori
    {
        List<Professor> PegarTodos();
        void Salvar(Professor professor);

        bool Remover(long id);
        Professor ObterPorId(long id);
    }
}
using WebApplication1.DTos;

namespace WebApplication1.Serviços.Interfaces
{
    public interface IProfessorServiçe


    {
        public List<ProfessorDTo> PegarTodos();
        void Salvar(ProfessorDTo professor);

        bool Remover(long id);
        void Editar(ProfessorDTo professor);
    }

}


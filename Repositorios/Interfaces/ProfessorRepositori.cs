using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexto;
using WebApplication1.Entidades;

namespace WebApplication1.Repositorios.Interfaces
{
    public class ProfessorRepositori : IProfessorRepositori
    {
        private readonly SenaiContext _context;


        public ProfessorRepositori(SenaiContext context)
        {
            _context = context;
        }

        public List<Professor> PegarTodos()
        {
            return _context.Professor.ToList();
        }


        public void Salvar(Professor professor)

        {
            if (professor.Id == 0)
                _context.Professor.Add(professor);
            else
                _context.Professor.Update(professor);

            _context.SaveChanges();

        }
        public bool Remover(long id)
        {
            try
            {
                _context.Professor.Where(u => u.Id == id).ExecuteDelete();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Professor ObterPorId(long id)
        {
            return _context.Professor.FirstOrDefault(e => e.Id == id);
        }

        public List<Professor> ObterTodos()
        {
            return _context.Professor.ToList();
        }
    }
}

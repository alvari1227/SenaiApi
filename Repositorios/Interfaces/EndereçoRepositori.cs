using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexto;
using WebApplication1.Entidades;

namespace WebApplication1.Repositorios.Interfaces
{
    public class EndereçoRepositori : IEndereçoRepositori
    {
        private readonly SenaiContext _context;


        public EndereçoRepositori(SenaiContext context)
        {
            _context = context;
        }

        public List<Endereço> PegarTodos()
        {
            return _context.Endereço.ToList();
        }


        public void Salvar(Endereço endereço)

        {
            if (endereço.Id == 0)
                _context.Endereço.Add(endereço);
            else
                _context.Endereço.Update(endereço);

            _context.SaveChanges();

        }
        public bool Remover(long id)
        {
            try
            {
                _context.Endereço.Where(u => u.Id == id).ExecuteDelete();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Endereço ObterPorId(long id)
        {
            return _context.Endereço.Include(c => c.Escola).FirstOrDefault(e => e.Id == id);
        }

        public List<Endereço> ObterTodos()
        {
            return _context.Endereço.ToList();
        }
    }
}

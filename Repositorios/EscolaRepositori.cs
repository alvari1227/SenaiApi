using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexto;
using WebApplication1.Entidades;
using WebApplication1.Repositorios.Interfaces;
using WebApplication1.Serviços.Interfaces;

namespace WebApplication1.Repositorios
{
    public class EscolaRepositori : BaseRepositori<Escola>, IEscola
    {
        private readonly SenaiContext _context;


        public EscolaRepositori(SenaiContext context) : base(context)
        {
            _context = context;
        }

        public List<Escola> PegarTodos()
        {
            return _context.Escola.ToList();
        }


        public void Salvar(Escola escola)

        {
            if (escola.Id == 0)
                _context.Escola.Add(escola);
            else
                _context.Escola.Update(escola);

            _context.SaveChanges();

        }
        public bool Remover(long id)
        {
            try
            {
                _context.Escola.Where(u => u.Id == id).ExecuteDelete();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Escola ObterPorId(long id)
        {
            return _context.Escola.FirstOrDefault(e => e.Id == id);
        }

        public List<Escola> ObterTodos()
        {
            return base.ObterTodos().ToList();
        }

    }
}

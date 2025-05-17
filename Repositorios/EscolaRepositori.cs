using WebApplication1.Contexto;
using WebApplication1.Entidades;
using WebApplication1.Repositorios.Interfaces;
using WebApplication1.Serviços.Interfaces;

namespace WebApplication1.Repositorios
{
    public class EscolaRepositori : IEscola
    {
        private readonly SenaiContext _context;

        
        public EscolaRepositori(SenaiContext context) { 
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
    }
}

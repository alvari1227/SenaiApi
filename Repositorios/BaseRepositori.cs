using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexto;

namespace WebApplication1.Repositorios
{
    public class BaseRepositori<T> : IBaseRepositori<T> where T : class
    {
        protected readonly SenaiContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepositori(SenaiContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IQueryable<T> ObterTodos()
        {
            return _dbSet;
        }
    }   
}

namespace WebApplication1.Repositorios
{
    public interface IBaseRepositori<T> where T : class
    {
        IQueryable<T> ObterTodos();
    }    
}

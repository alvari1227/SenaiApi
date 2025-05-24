using WebApplication1.DTos;

namespace WebApplication1.Serviços.Interfaces
{
    public interface IEndereçoServiçe
    
        
        {
            public List<EndereçoDTo> PegarTodos();
            void Salvar(EndereçoDTo endereço);

            bool Remover(long id);
            void Editar(EndereçoDTo endereço);
        }
    
}


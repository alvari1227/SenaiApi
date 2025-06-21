namespace WebApplication1.DTos
{
    public class EscolaDTo
    {
        public long Id { get; set; }
        public string Nome { get; set; }

        public EndereçoDTo? Endereço { get; set; }
    }
}

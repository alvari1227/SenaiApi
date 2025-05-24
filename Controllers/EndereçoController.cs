using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTos;
using WebApplication1.Serviços.Interfaces;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class EndereçoController : ControllerBase
    {
        private readonly IEndereçoServiçe _endereçoService;

        public EndereçoController(IEndereçoServiçe endereçoServiçe)
        {
            _endereçoService = endereçoServiçe;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Adicionar(EndereçoDTo endereço)
        {

            _endereçoService.Salvar(endereço);
            return Ok();
        }
        [HttpGet("buscar-todos")]
        public IActionResult Buscar()
        {
            var endereço = _endereçoService.PegarTodos();
            return Ok(endereço);
        }
        [HttpDelete]
        public IActionResult Remover(long id)
        {
            _endereçoService.Remover(id);
            return Ok();
        }
        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] EndereçoDTo endereço)
        {
            if (endereço == null)
            {
                return BadRequest("Escola nao pode ser nula");
            }
            _endereçoService.Editar(endereço);
            return Ok();
        }
    }
}

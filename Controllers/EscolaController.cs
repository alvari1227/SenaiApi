using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTos;
using WebApplication1.Entidades;
using WebApplication1.Serviços;
using WebApplication1.Serviços.Interfaces;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class EscolaController : ControllerBase
    {
        private readonly IEscolaServiçe _escolaService;
        
        public EscolaController(IEscolaServiçe escolaServiçe) {
            _escolaService = escolaServiçe;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Adicionar( EscolaDTo escola)
        {

            _escolaService.Salvar(escola);
            return Ok();
        }
        [HttpGet("buscar-todos")]
        public IActionResult Buscar()
        {
            var escolas = _escolaService.PegarTodos();
            return Ok(escolas);
        }
        [HttpDelete]
        public IActionResult Remover(long id)
        {
            _escolaService.Remover(id);
            return Ok();
        }
        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] EscolaEdiçaoDTo escola)
        {
            if (escola == null)
            {
                return BadRequest("Escola nao pode ser nula");
            }
            _escolaService.Editar(escola);
            return Ok();
        }
        
    }
}

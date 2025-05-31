using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTos;
using WebApplication1.Serviços.Interfaces;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorServiçe _professorService;

        public ProfessorController(IProfessorServiçe professorServiçe)
        {
            _professorService = professorServiçe;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Adicionar(ProfessorDTo professor)
        {

            _professorService.Salvar(professor);
            return Ok();
        }
        [HttpGet("buscar-todos")]
        public IActionResult Buscar()
        {
            var professor = _professorService.PegarTodos();
            return Ok(professor);
        }
        [HttpDelete]
        public IActionResult Remover(long id)
        {
            _professorService.Remover(id);
            return Ok();
        }
        [HttpPost]
        [Route("Editar")]
        public IActionResult Editar([FromBody] ProfessorDTo professor)
        {
            if (professor == null)
            {
                return BadRequest("Escola nao pode ser nula");
            }
            _professorService.Editar(professor);
            return Ok();
        }
    }
}
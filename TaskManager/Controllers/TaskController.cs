using Microsoft.AspNetCore.Mvc;
using TaskManager.Services;

namespace TaskManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private static readonly TaskService _service = new();

        [HttpPost]
        public IActionResult Criar(string titulo)
        {
            var tarefa = _service.Criar(titulo);
            return Ok(tarefa);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var tarefas = _service.Listar();
            return Ok(tarefas);
        }
    }
}
using TaskManager.Models;

namespace TaskManager.Services
{
    public class TaskService
    {
        private readonly List<Tarefa> _tarefas = new();

        public Tarefa Criar(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                throw new Exception("Título inválido");

            var tarefa = new Tarefa
            {
                Titulo = titulo
            };

            _tarefas.Add(tarefa);

            return tarefa;
        }

        public List<Tarefa> Listar()
        {
            return _tarefas;
        }
    }
}
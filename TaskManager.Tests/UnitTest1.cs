using NUnit.Framework;
using TaskManager.Services;

namespace TaskManager.Tests
{
    public class TaskServiceTests
    {
        [Test]
        public void DeveCriarTarefaValida()
        {
            var service = new TaskService();

            var tarefa = service.Criar("Estudar DevOps");

            Assert.That(tarefa, Is.Not.Null);
            Assert.That(tarefa.Titulo, Is.EqualTo("Estudar DevOps"));
        }

        [Test]
        public void NaoDeveCriarTarefaSemTitulo()
        {
            var service = new TaskService();

            Assert.Throws<Exception>(() => service.Criar(""));
        }

        [Test]
        public void DeveListarTarefasCriadas()
        {
            var service = new TaskService();

            service.Criar("Estudar DevOps");
            service.Criar("Fazer exercícios");

            var tarefas = service.Listar();

            Assert.That(tarefas.Count, Is.EqualTo(2));
        }
    }
}
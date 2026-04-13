# TaskManager API - Projeto DevOps + TDD

## Descrição
API simples de gerenciamento de tarefas desenvolvida em .NET, com foco em boas práticas de desenvolvimento, testes automatizados e integração contínua.

---

## Testes Automatizados (TDD)
O projeto utiliza NUnit para validação das regras de negócio.

### Cenários testados:
- Criação de tarefa com título válido
- Bloqueio de criação sem título
- Listagem de tarefas
- Lista vazia quando não há tarefas

---

## Integração Contínua (CI)
Pipeline configurado com GitHub Actions.

### Etapas automatizadas:
- Restore de dependências
- Build da aplicação
- Execução de testes
- Build da imagem Docker

---

##  Docker
A aplicação é containerizada utilizando Docker.

### Build da imagem:
```bash
docker build -t taskmanager-api .
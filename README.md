\# TaskFlow Console



Aplicação de gerenciamento de tarefas pelo terminal, desenvolvida em C# com .NET 10.



\## Funcionalidades



\- Adicionar tarefas.

\- Listar tarefas cadastradas.

\- Marcar tarefas como concluídas.

\- Validar títulos vazios ou inválidos.

\- Tratar buscas por tarefas inexistentes.



\## Requisitos



\- .NET 10 SDK



\## Como executar



Na pasta raiz do projeto, execute:



```powershell

dotnet build

dotnet run --project TaskFlow.Console

```



\## Como executar os testes



Execute:



```powershell

dotnet test

```



Os testes automatizados utilizam xUnit e verificam a criação de tarefas e a validação dos títulos.



\## Estrutura do projeto



\- `TaskFlow.Console/Domain`: entidade de tarefa.

\- `TaskFlow.Console/Services`: gerenciamento das tarefas.

\- `TaskFlow.Console/Program.cs`: menu interativo.

\- `TaskFlow.Tests`: testes automatizados.




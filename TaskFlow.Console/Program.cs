
using TaskFlow.Console.Services;

var manager = new TaskManager();
var running = true;

while (running)
{
    System.Console.WriteLine("\n=== TaskFlow ===");
    System.Console.WriteLine("1. Adicionar tarefa");
    System.Console.WriteLine("2. Listar tarefas");
    System.Console.WriteLine("3. Concluir tarefa");
    System.Console.WriteLine("0. Sair");
    System.Console.Write("Escolha uma opção: ");

    var option = System.Console.ReadLine();

    switch (option)
    {
        case "1":
            System.Console.Write("Digite o título da tarefa: ");
            var title = System.Console.ReadLine();

            try
            {
                var task = manager.AddTask(title!);
                System.Console.WriteLine(
                    $"Tarefa {task.Id} adicionada: {task.Title}");
            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine($"Erro: {ex.Message}");
            }

            break;

        case "2":
            var tasks = manager.GetAllTasks();

            if (tasks.Count == 0)
            {
                System.Console.WriteLine("Nenhuma tarefa cadastrada.");
            }
            else
            {
                foreach (var task in tasks)
                {
                    var status = task.IsCompleted
                        ? "Concluída"
                        : "Pendente";

                    System.Console.WriteLine(
                        $"{task.Id}. {task.Title} - {status}");
                }
            }

            break;

        case "3":
            System.Console.Write("Digite o ID da tarefa: ");
            var input = System.Console.ReadLine();

            if (int.TryParse(input, out var id))
            {
                if (manager.CompleteTask(id))
                {
                    System.Console.WriteLine("Tarefa concluída!");
                }
                else
                {
                    System.Console.WriteLine("Tarefa não encontrada.");
                }
            }
            else
            {
                System.Console.WriteLine("Digite um ID numérico válido.");
            }

            break;

        case "0":
            running = false;
            System.Console.WriteLine("Até logo!");
            break;

        default:
            System.Console.WriteLine("Opção inválida.");
            break;
    }
}

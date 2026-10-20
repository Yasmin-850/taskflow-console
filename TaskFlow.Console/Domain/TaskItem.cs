
namespace TaskFlow.Console.Domain;

public class TaskItem
{
    public int Id { get; }
    public string Title { get; }
    public bool IsCompleted { get; private set; }

    public TaskItem(int id, string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException(
                "O título da tarefa não pode ser vazio.",
                nameof(title));
        }

        Id = id;
        Title = title;
        IsCompleted = false;
    }

    public void ToggleCompletion()
    {
        IsCompleted = !IsCompleted;
    }
}

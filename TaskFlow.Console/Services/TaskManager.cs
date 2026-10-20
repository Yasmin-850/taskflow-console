
using TaskFlow.Console.Domain;

namespace TaskFlow.Console.Services;

public class TaskManager
{
    private readonly List<TaskItem> _tasks = new();
    private int _nextId = 1;

    public TaskItem AddTask(string title)
    {
        var task = new TaskItem(_nextId, title);
        _tasks.Add(task);
        _nextId++;

        return task;
    }

    public IReadOnlyList<TaskItem> GetAllTasks()
    {
        return _tasks.AsReadOnly();
    }

    public TaskItem? GetTaskById(int id)
    {
        return _tasks.FirstOrDefault(task => task.Id == id);
    }

    public bool CompleteTask(int id)
    {
        var task = GetTaskById(id);

        if (task is null)
        {
            return false;
        }

        task.ToggleCompletion();
        return true;
    }
}
